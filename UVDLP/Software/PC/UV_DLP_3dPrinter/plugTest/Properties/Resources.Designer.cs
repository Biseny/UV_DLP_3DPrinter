﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace plugTest.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("plugTest.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static byte[] binarytest {
            get {
                object obj = ResourceManager.GetObject("binarytest", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        public static System.Drawing.Bitmap doge {
            get {
                object obj = ResourceManager.GetObject("doge", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        public static System.Drawing.Bitmap index {
            get {
                object obj = ResourceManager.GetObject("index", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;MachineConfig FileVersion=&quot;1&quot;&gt;
        ///  &lt;PlatformXSize&gt;102&lt;/PlatformXSize&gt;
        ///  &lt;PlatformYSize&gt;77&lt;/PlatformYSize&gt;
        ///  &lt;PlatformZSize&gt;100&lt;/PlatformZSize&gt;
        ///  &lt;MaxXFeedRate&gt;100&lt;/MaxXFeedRate&gt;
        ///  &lt;MaxYFeedRate&gt;100&lt;/MaxYFeedRate&gt;
        ///  &lt;MaxZFeedRate&gt;100&lt;/MaxZFeedRate&gt;
        ///  &lt;MachineType&gt;UV_DLP&lt;/MachineType&gt;
        ///  &lt;MotorsDriverConfig&gt;
        ///    &lt;DriverType&gt;eGENERIC&lt;/DriverType&gt;
        ///    &lt;ComPortSettings&gt;
        ///      &lt;PortName&gt;COM58&lt;/PortName&gt;
        ///      &lt;Speed&gt;115200&lt;/Speed&gt;
        ///      &lt;Databits&gt;8&lt;/Databits&gt;
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        public static string text {
            get {
                return ResourceManager.GetString("text", resourceCulture);
            }
        }
    }
}
