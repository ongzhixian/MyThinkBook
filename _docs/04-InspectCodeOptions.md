# InspectCodeOptions Code


```cs
// Decompiled with JetBrains decompiler
// Type: JetBrains.CommandLine.InspectCode.Unattended.Settings.InspectCodeSettingsData
// Assembly: inspectcode, Version=777.0.0.0, Culture=neutral, PublicKeyToken=1010a0d8d6380325
// MVID: 623395CB-C1F4-4369-8035-482E9DB53247
// Assembly location: D:\src\github\MyThinkBook\jetbrains.resharper.globaltools.2021.3.2.nupkg\tools\netcoreapp3.1\any\inspectcode.exe

using JetBrains.Annotations;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharperAutomationTools.CommandLine.Common.Console.BatchTool.Settings;
using JetBrains.ReSharperAutomationTools.CommandLine.Common.Console.Util.Options;
using JetBrains.Util;
using System.ComponentModel;
using System.Xml.Serialization;

namespace JetBrains.CommandLine.InspectCode.Unattended.Settings
{
  [XmlType("InspectCodeOptions")]
  public class InspectCodeSettingsData : SettingsData
  {
    private bool? myNoBuild;
    private bool? myBuild;

    [XmlArray]
    [XmlArrayItem("CustomSettingsProfile")]
    [Option(Description = "Path to the file to use custom settings from (default: Use R#'s solution shared settings if exists)", Key = "profile", ShortKey = "p")]
    public string[] CustomSettingsProfiles { get; set; }

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

    [XmlElement("OutputFile")]
    [Option(Description = "Write inspections report to specified file", Key = "output", ShortKey = "o")]
    public string OutputFile { get; set; }

    [XmlElement("OutputFileFormat")]
    [Option(DefaultValue = InspectCodeOutputFormat.Xml, Description = "Write inspections report in specified format [Xml, Html, Text, Json]", Key = "format", ShortKey = "f")]
    public InspectCodeOutputFormat OutputFileFormat { get; set; }

    [XmlElement("ParallelJobs")]
    [TypeConverter(typeof (EnumConverter))]
    [Option(DefaultValue = 0, Description = "Run up to N jobs in parallel. 0 means as many as possible", Key = "jobs", ShortKey = "j")]
    public int ParallelJobs { get; set; }

    [XmlElement("UseAbsolutePaths")]
    [Option(DefaultValue = false, Description = "Use absolute paths in inspections report", Key = "absolute-paths", ShortKey = "a")]
    public bool UseAbsolutePaths { get; set; }

    [XmlElement("NoSolutionWideAnalysis")]
    [Option(DefaultValue = false, Description = "Force disable solution-wide analysis", Key = "no-swea")]
    public bool NoSolutionWideAnalysis { get; set; }

    [XmlElement("SolutionWideAnalysis")]
    [Option(DefaultValue = false, Description = "Force enable solution-wide analysis", Key = "swea")]
    public bool SolutionWideAnalysis { get; set; }

    [XmlArray]
    [XmlArrayItem("IncludedProjects")]
    [Option(Description = "Analyze only projects selected by provided wildcards (default: analyze all projects in solution)", Key = "project")]
    public string[] IncludedProjects { get; set; }

    [XmlArray]
    [XmlArrayItem("IncludedFiles")]
    [Option(Description = "Analyze only files selected by provided wildcards (default: analyze all files in solution)", Key = "include")]
    public string[] IncludedFiles { get; set; }

    [XmlArray]
    [XmlArrayItem("ExcludedFiles")]
    [Option(Description = "Exclude files selected by provided wildcards from analysis (default: analyze all files in solution)", Key = "exclude")]
    public string[] ExcludedFiles { get; set; }

    [XmlElement("DumpIssuesTypes")]
    [Option(DefaultValue = false, Description = "Dump issues types", Key = "dumpIssuesTypes", ShortKey = "it")]
    public bool DumpIssuesTypes { get; set; }

    [XmlElement("MinSeverity")]
    [TypeConverter(typeof (EnumConverter))]
    [Option(DefaultValue = Severity.SUGGESTION, Description = "Minimal severity level to report [INFO, HINT, SUGGESTION, WARNING, ERROR]", Key = "severity", ShortKey = "s")]
    public Severity MinSeverity { get; set; }

    [XmlElement("Measure")]
    [Option(Description = "Measure own tool's performance [MEMORY, SAMPLING, TIMELINE]", Key = "measure")]
    public SnapshotKind Measure { get; set; }

    [XmlElement("NoBuild")]
    [Option(DefaultValue = false, Description = "Do not build solution before processing", Key = "no-build")]
    public bool? NoBuild
    {
      get => this.myNoBuild;
      set
      {
        this.myNoBuild = value;
        if (this.myBuild.HasValue)
          return;
        bool? nullable = value;
        this.myBuild = nullable.HasValue ? new bool?(!nullable.GetValueOrDefault()) : new bool?();
      }
    }

    [XmlElement("Build")]
    [Option(DefaultValue = true, Description = "Build solution before processing", Key = "build")]
    public bool? Build
    {
      get => this.myBuild;
      set
      {
        this.myBuild = value;
        if (this.myNoBuild.HasValue)
          return;
        bool? nullable = value;
        this.myNoBuild = nullable.HasValue ? new bool?(!nullable.GetValueOrDefault()) : new bool?();
      }
    }

    [XmlElement("Target")]
    [Option(DefaultValue = "Build", Description = "MsBuild target to execute before processing.", Key = "target")]
    public string MsBuildTarget { get; set; }

    public InspectCodeSettingsData()
    {
      this.CustomSettingsProfiles = EmptyArray<string>.Instance;
      this.IncludedProjects = EmptyArray<string>.Instance;
      this.Extensions = EmptyArray<string>.Instance;
      this.Properties = EmptyArray<string>.Instance;
      this.TargetsForItems = EmptyArray<string>.Instance;
      this.TargetsForReferences = EmptyArray<string>.Instance;
      this.OutputFileFormat = InspectCodeOutputFormat.Xml;
      this.MinSeverity = Severity.SUGGESTION;
      this.ParallelJobs = 0;
    }
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