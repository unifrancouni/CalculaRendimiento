Public Class clEvaluator

    Private variables As List(Of String)
    Private exp As String

    Public Sub New()
        variables = New List(Of String)
        exp = ""
    End Sub

    Public Sub New(ByVal expresion As String)
        variables = New List(Of String)
        exp = ""
        Me.Parse(expresion)
    End Sub

    Public Sub addVariable(ByVal nombre As String, ByVal value As String)
        variables.Add(nombre & ":" & value)
    End Sub

    Public Sub Parse(ByVal expresion As String)
        Dim i As Integer
        If variables.Count > 0 Then
            For i = 0 To variables.Count - 1
                expresion = expresion.Replace(getVariableName(i), "CDbl(" & getVariableValue(i) & ")")
            Next
        End If
        Me.exp = expresion
    End Sub

    Public Function Eval() As String
        Return Replace(Math.Round(CDbl(clEvalProvider.Eval(exp)), 4), ",", ".")
    End Function

    Private Function getVariableName(ByVal index As Integer) As String
        Dim var As String = variables(index)
        Dim partes As String() = var.Split(":")
        Return partes(0)
    End Function

    Private Function getVariableValue(ByVal index As Integer) As String
        Dim var As String = variables(index)
        Dim partes As String() = var.Split(":")
        Return partes(1)
    End Function




End Class
