﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VM.Platform.TestAutomationFramework.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VM.Platform.TestAutomationFramework.Core.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConditionsLogFileName.
        /// </summary>
        internal static string ConditionsLogFileName {
            get {
                return ResourceManager.GetString("ConditionsLogFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 10000.
        /// </summary>
        internal static string DefaultImplicitWaitTime {
            get {
                return ResourceManager.GetString("DefaultImplicitWaitTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ExecutionLogFileName.
        /// </summary>
        internal static string ExecutionLogFileName {
            get {
                return ResourceManager.GetString("ExecutionLogFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot;&gt;
        ///    &lt;xsl:template match=&quot;testRun&quot;&gt;
        ///        &lt;html&gt;
        ///
        ///        &lt;head&gt;
        ///            &lt;style&gt;
        ///                body {
        ///                    font-family: Arial;
        ///                }
        ///
        ///                dl {
        ///                    width: 395px;
        ///                    font-size: 12px
        ///                }
        ///
        ///                dd {
        ///                    margin-left: 120px
        ///                }
        ///
        ///            [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestRunResultsReportTemplate {
            get {
                return ResourceManager.GetString("TestRunResultsReportTemplate", resourceCulture);
            }
        }
    }
}
