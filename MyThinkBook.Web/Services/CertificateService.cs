using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace MyThinkBook.Web.Services;

public class CertificateService
{
    public static X509Certificate2 CreateSelfSignedCert(string CommonName, string Password, string Destination, string FriendlyName = null, string[] DnsNames = null, DateTime? ExpirationBefore = null, DateTime? ExpirationAfter = null, bool IsCertificateAuthority = false, string CountryCode = "US", string Organization = "JCCE", string[] OrganizationalUnits = null)
    {
        SubjectAlternativeNameBuilder sanBuilder = new SubjectAlternativeNameBuilder();
        if (DnsNames == null)
        {
            sanBuilder.AddIpAddress(IPAddress.Loopback);
            sanBuilder.AddIpAddress(IPAddress.IPv6Loopback);
            sanBuilder.AddDnsName("localhost");
            sanBuilder.AddDnsName(Environment.MachineName);
        }
        else
        {
            foreach (var dnsName in DnsNames)
            {
                sanBuilder.AddDnsName(dnsName);
            }
        }

        if (CountryCode.Length != 2) CountryCode = "US";

        if (OrganizationalUnits == null) OrganizationalUnits = new[] { "Copyright (c), " + DateTime.UtcNow.ToString("yyyy") + " JCCE" };

        var dn = new StringBuilder();

        dn.Append("CN=\"" + CommonName.Replace("\"", "\"\"") + "\"");
        foreach (var ou in OrganizationalUnits)
        {
            dn.Append(",OU=\"" + ou.Replace("\"", "\"\"") + "\"");
        }
        dn.Append(",O=\"" + Organization.Replace("\"", "\"\"") + "\"");
        dn.Append(",C=" + CountryCode.ToUpper());
        dn.Append(",C=" + "JP");

        var strDn = dn.ToString();

        X500DistinguishedName distinguishedName = new X500DistinguishedName(strDn);

        X509Certificate2 cert;

        using (RSA rsa = RSA.Create(2048))
        {
            var request = new CertificateRequest(distinguishedName, rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            var usages = X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.DigitalSignature;

            if (IsCertificateAuthority) usages = usages | X509KeyUsageFlags.KeyCertSign;

            request.CertificateExtensions.Add(new X509KeyUsageExtension(usages, false));


            request.CertificateExtensions.Add(
               new X509EnhancedKeyUsageExtension(
                   new OidCollection { new Oid("1.3.6.1.5.5.7.3.1") }, false));

            request.CertificateExtensions.Add(sanBuilder.Build());

            if (IsCertificateAuthority) request.CertificateExtensions.Add(new X509BasicConstraintsExtension(true, true, 1, true));

            if (ExpirationAfter == null) { ExpirationAfter = DateTime.UtcNow.AddDays(-1).AddYears(10); }

            if (ExpirationBefore == null) ExpirationBefore = DateTime.UtcNow;

            var certificate = request.CreateSelfSigned(new DateTimeOffset(ExpirationBefore.Value), new DateTimeOffset(ExpirationAfter.Value));
            if (FriendlyName == null) FriendlyName = CommonName;
            certificate.FriendlyName = FriendlyName;

            cert = new X509Certificate2(certificate.Export(X509ContentType.Pfx, Password), Password, X509KeyStorageFlags.MachineKeySet);

            File.WriteAllBytes(Destination, certificate.Export(X509ContentType.Pkcs12, Password));

        }

        return cert;

    }

    public static Guid CreateSignedCert(string IssuerCertLocation, string IssuerPassword, string CommonName, string Password, string Destination, string FriendlyName = null, string[] DnsNames = null, DateTime? ExpirationBefore = null, DateTime? ExpirationAfter = null, string CountryCode = "US", string Organization = "JCCE", string[] OrganizationalUnits = null)
    {
        SubjectAlternativeNameBuilder sanBuilder = new SubjectAlternativeNameBuilder();
        if (DnsNames == null)
        {
            sanBuilder.AddIpAddress(IPAddress.Loopback);
            sanBuilder.AddIpAddress(IPAddress.IPv6Loopback);
            sanBuilder.AddDnsName("localhost");
            sanBuilder.AddDnsName(Environment.MachineName);
        }
        else
        {
            foreach (var dnsName in DnsNames)
            {
                sanBuilder.AddDnsName(dnsName);
            }
        }


        if (CountryCode.Length != 2) CountryCode = "US";

        if (OrganizationalUnits == null) OrganizationalUnits = new[] { "Copyright (c), " + DateTime.UtcNow.ToString("yyyy") + " \"JCCE\"", "JcceEventBusServer" };

        var dn = new StringBuilder();

        dn.Append("CN=\"" + CommonName.Replace("\"", "\"\"") + "\"");
        foreach (var ou in OrganizationalUnits)
        {
            dn.Append(";OU=\"" + ou.Replace("\"", "\"\"") + "\"");
        }
        dn.Append(";O=\"" + Organization.Replace("\"", "\"\"") + "\"");
        dn.Append(";C=" + CountryCode.ToUpper());
        dn.Append(";C=" + "JP");


        var strDn = dn.ToString();

        X500DistinguishedName distinguishedName = new X500DistinguishedName(strDn);


        var issuerCert = new X509Certificate2(fileName: IssuerCertLocation, password: IssuerPassword, keyStorageFlags: X509KeyStorageFlags.Exportable | X509KeyStorageFlags.MachineKeySet);

        var uniqueId = Guid.NewGuid();


        var csp = new CspParameters
        {
            Flags = CspProviderFlags.UseArchivableKey | CspProviderFlags.UseMachineKeyStore
        };

        using (var rsa = new RSACryptoServiceProvider(2048, csp))
        {
            var request = new CertificateRequest(distinguishedName, rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            request.CertificateExtensions.Add(
                new X509KeyUsageExtension(X509KeyUsageFlags.KeyAgreement | X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.DigitalSignature, true));

            request.CertificateExtensions.Add(
               new X509EnhancedKeyUsageExtension(
                   new OidCollection { new Oid("1.3.6.1.5.5.7.3.1"), new Oid("1.3.6.1.5.5.7.3.2") }, true));

            request.CertificateExtensions.Add(sanBuilder.Build());

            if (ExpirationAfter == null) { ExpirationAfter = issuerCert.NotAfter.Date; } //DateTime.ParseExact(issuerCert.GetExpirationDateString(), "M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture); }

            if (ExpirationBefore == null) ExpirationBefore = DateTime.UtcNow;

            var certificate = request.Create(issuerCert, new DateTimeOffset(ExpirationBefore.Value), new DateTimeOffset(ExpirationAfter.Value), uniqueId.ToByteArray());

            certificate.PrivateKey = rsa;

            if (FriendlyName == null) FriendlyName = CommonName;
            certificate.FriendlyName = FriendlyName;

            var key = certificate.GetRSAPrivateKey();  // <-- This piece of shit is always NULL!!!!!!!!

            File.WriteAllBytes(Destination, certificate.Export(X509ContentType.Pfx, Password));
        }

        return uniqueId;

    }

    // See: https://www.wiktorzychla.com/2012/12/how-to-create-x509certificate2.html
    // See: https://www.reddit.com/r/csharp/comments/bp30fw/how_to_programmatically_generate_a_certificate/
    // See also: https://blog.rassie.dk/2018/04/creating-an-x-509-certificate-chain-in-c/
}
