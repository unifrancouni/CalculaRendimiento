'Imports Microsoft.VisualBasic
Imports System

Public Class clEvalProvider


    Public Shared Function Eval(ByVal vbCode As String) As Object
        Dim c As VBCodeProvider = New VBCodeProvider
        Dim icc As System.CodeDom.Compiler.ICodeCompiler = c.CreateCompiler()
        Dim cp As System.CodeDom.Compiler.CompilerParameters = New System.CodeDom.Compiler.CompilerParameters

        cp.ReferencedAssemblies.Add("System.dll")
        cp.ReferencedAssemblies.Add("System.xml.dll")
        cp.ReferencedAssemblies.Add("System.data.dll")
        ' Sample code for adding your own referenced assemblies
        'cp.ReferencedAssemblies.Add("c:\yourProjectDir\bin\YourBaseClass.dll")
        'cp.ReferencedAssemblies.Add("YourBaseclass.dll")
        cp.CompilerOptions = "/t:library"
        cp.GenerateInMemory = True
        Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder("")
        sb.Append("Imports System" & vbCrLf)
        sb.Append("Imports System.Xml" & vbCrLf)
        sb.Append("Imports System.Data" & vbCrLf)
        sb.Append("Imports System.Data.SqlClient" & vbCrLf)
        sb.Append("Imports Microsoft.VisualBasic" & vbCrLf)

        sb.Append("Namespace MyEvalNamespace  " & vbCrLf)
        sb.Append("Class MyEvalClass " & vbCrLf)

        sb.Append("public function  EvalCode() as Object " & vbCrLf)
        'sb.Append("YourNamespace.YourBaseClass thisObject = New YourNamespace.YourBaseClass()")
        sb.Append("Return " & vbCode & vbCrLf)
        sb.Append("End Function " & vbCrLf)
        sb.Append("End Class " & vbCrLf)
        sb.Append("End Namespace" & vbCrLf)
        Debug.WriteLine(sb.ToString()) ' look at this to debug your eval string
        Dim cr As System.CodeDom.Compiler.CompilerResults = icc.CompileAssemblyFromSource(cp, sb.ToString())
        Dim a As System.Reflection.Assembly = cr.CompiledAssembly
        Dim o As Object
        Dim mi As System.Reflection.MethodInfo
        o = a.CreateInstance("MyEvalNamespace.MyEvalClass")
        Dim t As Type = o.GetType()
        mi = t.GetMethod("EvalCode")
        Dim s As Object
        s = mi.Invoke(o, Nothing)
        Return s
    End Function


End Class ' EvalProvider
