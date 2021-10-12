using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToLiteral
{
    public static class StringExtension
    {
	    public static string ToLiteral(this string source)
	    {
		    using var writer = new StringWriter();
		    using var provider = CodeDomProvider.CreateProvider("CSharp");

		    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(source), writer, new CodeGeneratorOptions()
		    {
			    VerbatimOrder = false,
				BlankLinesBetweenMembers = true,
				BracingStyle = "C",
				IndentString = "",
				ElseOnClosing = true
		    });

		    return writer.ToString();
	    }
    }
}
