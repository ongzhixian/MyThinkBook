using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MyThinkBook.Web.HealthChecks.Tests;

[TestClass()]
public class HealthCheckPublisherTests
{
    [TestMethod()]
    public void PublishAsyncTestAsync()
    {
        IReadOnlyDictionary<string, HealthReportEntry> entries = new Dictionary<string, HealthReportEntry>
        {
            { "someHealthReportEntry", new HealthReportEntry() }
        };
        TimeSpan totalDuration = TimeSpan.FromSeconds(1);

        var healthReport = new HealthReport(entries, totalDuration);
        
        var cancellationToken = new CancellationToken();

        var healthCheckPublisher = new HealthCheckPublisher();

        Task task = healthCheckPublisher.PublishAsync(healthReport, cancellationToken);
        
        Assert.IsTrue(task.IsCompleted);
    }
}