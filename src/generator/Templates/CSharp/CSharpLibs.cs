﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Templates {
    using System;
    
    
    public partial class CSharpLibs : Base {
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 2 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write("// -------------------------------------------------------------------------\n//  C++ libarary declarations\n//  Generated on ");
            
            #line default
            #line hidden
            
            #line 4 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( DateTime.Now ));
            
            #line default
            #line hidden
            
            #line 4 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write("\n//\n//  This file was auto generated. Do not edit.\n// -------------------------------------------------------------------------\n\nusing System;\nusing Mono.VisualC.Interop;\n\nnamespace ");
            
            #line default
            #line hidden
            
            #line 12 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Generator.Namespace ));
            
            #line default
            #line hidden
            
            #line 12 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write(" {\n\n\tpublic static partial class Libs {\n\n\t\tpublic static readonly CppLibrary ");
            
            #line default
            #line hidden
            
            #line 16 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Generator.LibBaseName ));
            
            #line default
            #line hidden
            
            #line 16 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write(" = new CppLibrary (\"");
            
            #line default
            #line hidden
            
            #line 16 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Generator.LibBaseName ));
            
            #line default
            #line hidden
            
            #line 16 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write("\", InlineMethods.");
            
            #line default
            #line hidden
            
            #line 16 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Generator.InlinePolicy ));
            
            #line default
            #line hidden
            
            #line 16 "/Users/alex/OpenSource/cppinterop/src/generator/Templates/CSharp/CSharpLibs.tt"
            this.Write(");\n\n\t}\n}\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        protected override void Initialize() {
            base.Initialize();
        }
    }
}