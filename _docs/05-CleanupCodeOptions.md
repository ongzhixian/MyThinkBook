# CleanupCodeOptions

```cs
// Decompiled with JetBrains decompiler
// Type: JetBrains.CommandLine.CleanupCode.Unattended.Settings.CleanupCodeSettingsData
// Assembly: cleanupcode, Version=777.0.0.0, Culture=neutral, PublicKeyToken=1010a0d8d6380325
// MVID: 79F59E1E-B979-4A80-B245-304533F11946
// Assembly location: C:\Users\zhixian\AppData\Local\Temp\Culewop\ea0d05144d\tools\netcoreapp3.1\any\cleanupcode.exe

using JetBrains.Annotations;
using JetBrains.ReSharperAutomationTools.CommandLine.Common.Console.BatchTool.Settings;
using JetBrains.ReSharperAutomationTools.CommandLine.Common.Console.Util.Options;
using JetBrains.Util;
using System.Xml.Serialization;

namespace JetBrains.CommandLine.CleanupCode.Unattended.Settings
{
  [XmlType("CleanupCodeOptions")]
  public class CleanupCodeSettingsData : SettingsData
  {
    [CanBeNull]
    [XmlElement("CustomSettingsProfile")]
    public string CustomSettingsProfile
    {
      get => (string) null;
      set => this.CustomSettingsProfiles = new string[1]
      {
        value
      };
    }

    [XmlArray]
    [XmlArrayItem("CustomSettingsProfile")]
    [Option(Description = "Path to the file to use custom settings from (default: Use R#'s solution shared settings if exists)", Key = "settings", ShortKey = "s")]
    public string[] CustomSettingsProfiles { get; set; }

    [CanBeNull]
    [XmlElement("CleanupProfileName")]
    [Option(Description = "Name of the code cleanup profile. Full cleanup profile is used if nothing specified", Key = "profile", ShortKey = "p")]
    public string CleanupProfileName { get; set; }

    [CanBeNull]
    [XmlElement("CleanupScopeInclude")]
    [Option(Description = "Set of relative paths separated by ';' that defines which files should be cleaned up. Might contains single ('*') and double ('**') wildcards.", Key = "include")]
    public string Include { get; set; }

    [CanBeNull]
    [XmlElement("CleanupScopeExclude")]
    [Option(Description = "Set of relative paths separated by ';' that defines which files should not be cleaned up. Might contains single ('*') and double ('**') wildcards. If defined along with 'included' takes higher priority')", Key = "exclude")]
    public string Exclude { get; set; }

    public CleanupCodeSettingsData() => this.CustomSettingsProfiles = EmptyArray<string>.Instance;
  }
}
```

``` cs
// Decompiled with JetBrains decompiler
// Type: JetBrains.ReSharperAutomationTools.CommandLine.Common.Console.BatchTool.Settings.SettingsData
// Assembly: JetBrains.ReSharperAutomationTools.CommandLine.Common, Version=777.0.0.0, Culture=neutral, PublicKeyToken=1010a0d8d6380325
// MVID: 110432A5-8BC7-44A8-96AA-F7E05E003272
// Assembly location: C:\Users\zhixian\AppData\Local\Temp\Culewop\ea0d05144d\tools\netcoreapp3.1\any\JetBrains.ReSharperAutomationTools.CommandLine.Common.dll

using JetBrains.Annotations;
using JetBrains.Diagnostics;
using JetBrains.ReSharperAutomationTools.CommandLine.Common.Console.Util;
using JetBrains.ReSharperAutomationTools.CommandLine.Common.Console.Util.Options;
using JetBrains.Util;
using System.ComponentModel;
using System.Xml.Serialization;

namespace JetBrains.ReSharperAutomationTools.CommandLine.Common.Console.BatchTool.Settings
{
  public class SettingsData : ICodeSettingsDataWithExtensions
  {
    public SettingsData()
    {
      this.DisabledSettingsLayers = EmptyArray<string>.Instance;
      this.Extensions = EmptyArray<string>.Instance;
      this.ExtensionSources = EmptyArray<string>.Instance;
      this.Properties = EmptyArray<string>.Instance;
      this.TargetsForItems = EmptyArray<string>.Instance;
      this.TargetsForReferences = EmptyArray<string>.Instance;
      this.Verbosity = LoggingLevel.INFO;
    }

    [XmlElement("Debug")]
    [Option(DefaultValue = false, Description = "Show debugging messages", Key = "debug", ShortKey = "d")]
    public bool Debug { get; set; }

    [XmlElement("Verbosity")]
    [TypeConverter(typeof (EnumConverter))]
    [Option(DefaultValue = LoggingLevel.INFO, Description = "Display this amount of information in the log [OFF, FATAL, ERROR, WARN, INFO, VERBOSE, TRACE]", Key = "verbosity")]
    public LoggingLevel Verbosity { get; set; }

    [XmlIgnore]
    [Option(Description = "Show help and exit", Key = "help", ShortKey = "h")]
    public bool ShowHelp { get; set; }

    [XmlIgnore]
    [Option(Description = "Show tool version and exit", Key = "version", ShortKey = "v")]
    public bool ShowVersion { get; set; }

    [CanBeNull]
    [XmlElement("SolutionFile")]
    public string SolutionFile { get; set; }

    [XmlElement("Toolset")]
    [Option(Description = "MsBuild toolset version. Highest available is used by default. Example: --toolset=12.0", Key = "toolset")]
    public string Toolset { get; set; }

    [XmlElement("ToolsetPath")]
    [Option(Description = "MsBuild toolset (exe/dll) path. Example: --toolset-path=/usr/local/msbuild/bin/current/MSBuild.exe", Key = "toolset-path")]
    public string ToolsetPath { get; set; }

    [XmlElement("Mono")]
    [Option(Description = "Mono path. Empty to ignore Mono. Not specified for autodetect. Example: --mono=/Library/Frameworks/Mono.framework/Versions/Current/bin/mono", Key = "mono")]
    public string Mono { get; set; }

    [XmlElement("DotNetCore")]
    [Option(Description = ".NET Core path. Empty to ignore .NET Core. Not specified for autodetect. Example: --dotnetcore=/usr/local/share/dotnet/dotnet", Key = "dotnetcore")]
    public string DotNetCore { get; set; }

    [XmlElement("DotNetCoreSdk")]
    [Option(Description = ".NET Core SDK version. Example: --dotnetcoresdk=3.0.100", Key = "dotnetcoresdk")]
    public string DotNetCoreSdk { get; set; }

    [XmlArray]
    [XmlArrayItem("Layer")]
    [Option(Description = "Disable specified settings layers. Possible values: GlobalAll, GlobalPerProduct, SolutionShared, SolutionPersonal, ProjectShared, ProjectPersonal", Key = "disable-settings-layers", ShortKey = "dsl")]
    public string[] DisabledSettingsLayers { get; set; }

    [XmlElement("SuppressBuildInSettings")]
    [Option(DefaultValue = false, Description = "Suppress global, solution and project settings profile usage. Alias for --disable-settings-layers:GlobalAll;GlobalPerProduct;SolutionShared;SolutionPersonal;ProjectShared;ProjectPersonal", Key = "no-buildin-settings")]
    public bool SuppressBuildInSettings { get; set; }

    [XmlElement("CachesHomeDirectory")]
    [Option(Description = "Path to the directory where produced caches will be stored", Key = "caches-home")]
    public string CachesHomeDirectory { get; set; }

    [XmlArray]
    [XmlArrayItem("Properties")]
    [Option(Description = "MSBuild properties", Key = "properties")]
    public string[] Properties { get; set; }

    [XmlArray]
    [XmlArrayItem("TargetsForReferences")]
    [Option(Description = "MSBuild targets. These targets will be executed to get referenced assemblies of projects.", Key = "targets-for-references")]
    public string[] TargetsForReferences { get; set; }

    [XmlArray]
    [XmlArrayItem("TargetsForReferences")]
    [Option(Description = "MSBuild targets. These targets will be executed to get other items (e.g. Compile item) of projects.", Key = "targets-for-items")]
    public string[] TargetsForItems { get; set; }

    [XmlArray]
    [XmlArrayItem("Extension")]
    [Option(Description = "Install and use specified extensions", Key = "eXtensions", ShortKey = "x")]
    public string[] Extensions { get; set; }

    [XmlArray]
    [XmlArrayItem("ExtensionSource")]
    [Option(Description = "Install extensions from specified source(s)", Key = "source", ShortKey = "s")]
    public string[] ExtensionSources { get; set; }
  }
}
```