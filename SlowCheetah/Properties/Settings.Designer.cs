﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlowCheetah.VisualStudio.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft\\MSBuild\\SlowCheetah\\v1\\")]
        public string InstallPath {
            get {
                return ((string)(this["InstallPath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SlowCheetah.Xdt.dll")]
        public string TransformAssemblyPath {
            get {
                return ((string)(this["TransformAssemblyPath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%LOCALAPPDATA%")]
        public string InstallUserFolder {
            get {
                return ((string)(this["InstallUserFolder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$(LOCALAPPDATA)")]
        public string InstallUserFolderMSBuild {
            get {
                return ((string)(this["InstallUserFolderMSBuild"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SlowCheetah.Transforms.targets")]
        public string TargetsFilename {
            get {
                return ((string)(this["TargetsFilename"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SlowCheetahTargets")]
        public string SlowCheetahTargets {
            get {
                return ((string)(this["SlowCheetahTargets"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".htm;.html;.cs.vb;.txt;.jpg;.png;.ico;.aspx;.snk;.dll;.pdb;.settings")]
        public string ExcludedFileExtensions {
            get {
                return ((string)(this["ExcludedFileExtensions"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SlowCheetah.Xdt.TransformXml")]
        public string TransformXmlTaskName {
            get {
                return ((string)(this["TransformXmlTaskName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SlowCheetah")]
        public string SlowCheetahNugetPkgName {
            get {
                return ((string)(this["SlowCheetahNugetPkgName"]));
            }
            set {
                this["SlowCheetahNugetPkgName"] = value;
            }
        }
    }
}
