﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfileBackupTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultServer {
            get {
                return ((string)(this["DefaultServer"]));
            }
            set {
                this["DefaultServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\C$\\Users")]
        public string SourceDirectory {
            get {
                return ((string)(this["SourceDirectory"]));
            }
            set {
                this["SourceDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DestinationDirectory {
            get {
                return ((string)(this["DestinationDirectory"]));
            }
            set {
                this["DestinationDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CalculateProfileSizes {
            get {
                return ((bool)(this["CalculateProfileSizes"]));
            }
            set {
                this["CalculateProfileSizes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseCustomDestination {
            get {
                return ((bool)(this["UseCustomDestination"]));
            }
            set {
                this["UseCustomDestination"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CopyAll {
            get {
                return ((bool)(this["CopyAll"]));
            }
            set {
                this["CopyAll"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowErrors {
            get {
                return ((bool)(this["ShowErrors"]));
            }
            set {
                this["ShowErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ForceUserLogoff {
            get {
                return ((bool)(this["ForceUserLogoff"]));
            }
            set {
                this["ForceUserLogoff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2016-01-01")]
        public global::System.DateTime TransferDateThreshold {
            get {
                return ((global::System.DateTime)(this["TransferDateThreshold"]));
            }
            set {
                this["TransferDateThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RestoreMode {
            get {
                return ((bool)(this["RestoreMode"]));
            }
            set {
                this["RestoreMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Desktop</string>
  <string>Documents</string>
  <string>Downloads</string>
  <string>Favorites</string>
  <string>Pictures</string>
  <string>Music</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Folders {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Folders"]));
            }
            set {
                this["Folders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection OriginalDevices {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["OriginalDevices"]));
            }
            set {
                this["OriginalDevices"] = value;
            }
        }
    }
}
