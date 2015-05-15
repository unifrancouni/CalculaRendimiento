﻿' Códigos de error:
' -------------------------------------------------------------------------------------
' 000: N% no puede ser implícita.
' 001: La cantidad de números reales, ecuaciones implícitas, o vacías no es válida.
' 001: Dos variables del mismo concepto no pueden ser implícitas.
' 003: Dos variables del mismo concepto no pueden ser vacías.


'ESTÁNDAR:
'----------------------------------------------------------------------------------------
'-NOMBRES DE FUNCIONES: EMPIEZAN POR MINÚSCULA, 
' Y LA PRIMER LETRA DE CADA PALABRA DIFERENTE EN MAYÚSCULA.
'-COLOCAR UN COMENTARIO DE LA FUNCIÓN QUE REALIZA CADA MÉTDODO


Imports SingularSys.Jep
Imports System.Text.RegularExpressions


Public Class frmPrincipal


#Region "Variables Globales"

    Dim j As JepInstance

#End Region

#Region "Eventos Form"

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'j = New JepInstance()
        'j.Parse("2+4*5")
        'MsgBox(j.Evaluate().ToString)

    End Sub

#End Region

#Region "Validaciones"

    Private Sub validarFormato(ByRef txt As TextBox, ByVal strVar As String)
        'VALIDA SI UN TEXTO TIENE EL FORMATO CORRECTO: NºREAL|NºREAL*VARIABLE
        '255; 192; 192 ROJO
        '192; 255; 192 VERDE
        If Not Regex.IsMatch(txt.Text, "^(()|([0-9]{1,}(.[0-9]{1,})?(\*" & strVar & ")?))$") Then
            errSintaxisTxt.SetError(txt, IIf(strVar <> "", "El formato correcto es: N°REAL|N°REAL*" & strVar, "El formato correcto es: N°REAL"))
            txt.BackColor = Color.FromArgb(255, 255, 192, 192)
        Else
            errSintaxisTxt.Clear()
            If txt.Text <> "" Then
                txt.BackColor = Color.FromArgb(255, 192, 255, 192)
            Else
                txt.BackColor = Color.FromArgb(255, 255, 255, 255)
            End If
        End If
    End Sub

    Private Function validarBalanceDatos() As Boolean
        'Balancear los datos de entrada significa, verificar que entren cierta cantidad de números
        'así como cierta cantidad de ecuaciones implícitas, y que sea válido (quienes pueden y 
        'quienes no ser implícitos).
        '   Matemáticamente, existe de dentro de lo posible:
        '   6 NÚMEROS, 0 IMPLÍCITO, 1 VACÍO
        '   4 NÚMEROS, 1 IMPLÍCITO, 2 VACÍO 
        '   2 NÚMEROS, 2 IMPLÍCITO, 3 VACÍO
        '   0 NÚMEROS, 3 IMPLÍCITO, 4 VACÍO
        '   TOMANDO EN CUENTA QUE N% NUNCA DEBE SER VACÍA

        If esImplicita(txt_n_b_a.Text) Then
            MsgBox("N% nunca debe ser implícita.", vbCritical, "Error código: 000")
            Return False
        Else
            If Not (CantidadImplicitas() = 0 And CantidadNumeros() = 6 And CantidadVacias() = 1) Then
                If Not (CantidadNumeros() = 4 And CantidadImplicitas() = 1 And CantidadVacias() = 2) Then
                    If Not (CantidadNumeros() = 2 And CantidadImplicitas() = 2 And CantidadVacias() = 3) Then
                        If Not (CantidadNumeros() = 0 And CantidadImplicitas() = 3 And CantidadVacias() = 4) Then
                            MsgBox("La cantidad de números reales, ecuaciones implícitas, o vacías no es válida.", vbCritical, "Error código: 001")
                            Return False
                        End If
                    End If
                End If
            End If
            If (esImplicita(txtNa.Text) And esImplicita(txtNb.Text)) _
                               Or (esImplicita(txtCPIa.Text) And esImplicita(txtCPIb.Text)) _
                               Or (esImplicita(txtFa.Text) And esImplicita(txtFb.Text)) Then
                MsgBox("Dos variables del mismo concepto no pueden ser implícitas.", vbCritical, "Error código: 002")
                Return False
            End If
            If (esVacia(txtNa.Text) And esVacia(txtNb.Text)) _
                Or (esVacia(txtCPIa.Text) And esVacia(txtCPIb.Text)) _
                Or (esVacia(txtFa.Text) And esVacia(txtFb.Text)) Then
                MsgBox("Dos variables del mismo concepto no pueden ser vacías.", vbCritical, "Error código: 003")
                Return False
            End If
        End If

        Return True
    End Function

#End Region

#Region "Botones de Agregar Variable Implícita"
    'CADA BOTÓN AGREGA SU VARIABLE CORRESPONDIENTE

    Private Sub btnAddNb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNb.Click
        If txtNa.TextLength > 0 Then
            addText(txtNa, "*NB")
        End If
    End Sub

    Private Sub btnAddNa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNa.Click
        If txtNb.TextLength > 0 Then
            addText(txtNb, "*NA")
        End If
    End Sub

    Private Sub btnAddCPIb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCPIb.Click
        If txtCPIa.TextLength > 0 Then
            addText(txtCPIa, "*CPIB")
        End If
    End Sub

    Private Sub btnAddCPIa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCPIa.Click
        If txtCPIb.TextLength > 0 Then
            addText(txtCPIb, "*CPIA")
        End If
    End Sub

    Private Sub btnAddFb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFb.Click
        If txtFa.TextLength > 0 Then
            addText(txtFa, "*FB")
        End If
    End Sub

    Private Sub btnAddFa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFa.Click
        If txtFb.TextLength > 0 Then
            addText(txtFb, "*FA")
        End If
    End Sub

#End Region

#Region "Botones de Eliminar"
    'CADA BOTÓN ELIMINA O LIMPIA UN TEXTBOX CORRESPONDIENTE

    Private Sub btnClearNa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearNa.Click
        txtNa.Text = ""
    End Sub

    Private Sub btnClearNb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearNb.Click
        txtNb.Text = ""
    End Sub

    Private Sub btnClearCPIa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearCPIa.Click
        txtCPIa.Text = ""
    End Sub

    Private Sub btnClearCPIb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearCPIb.Click
        txtCPIb.Text = ""
    End Sub

    Private Sub btnClearFa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFa.Click
        txtFa.Text = ""
    End Sub

    Private Sub btnClearFb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFb.Click
        txtFb.Text = ""
    End Sub

    Private Sub btnClear_n_b_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear_n_b_a.Click
        txt_n_b_a.Text = ""
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        'LIMPIA TODOS LOS TEXTBOX
        btnClearNa_Click(sender, e)
        btnClearNb_Click(sender, e)
        btnClearCPIa_Click(sender, e)
        btnClearCPIb_Click(sender, e)
        btnClearFa_Click(sender, e)
        btnClearFb_Click(sender, e)
        btnClear_n_b_a_Click(sender, e)
    End Sub

#End Region

#Region "Funciones"

    Private Sub addText(ByRef textBox As TextBox, ByVal str As String)
        'AGREGA UN TEXTO A UN TEXTBOX
        textBox.Text &= str
        textBox.SelectionStart = textBox.TextLength
    End Sub

    Private Function esImplicita(ByVal exp As String) As Boolean
        'DEVUELVE TRUE SI UNA CADENA ES MATEMÁTICAMENTE UNA ECUACIÓN IMPLÍCITA
        'ES EVIDENTE QUE UNA EXPRESIÓN ES UNA ECUACIÓN IMPLÍCITA SI LLEVA UN *
        If exp.Contains("*") Then
            Return True
        End If
        Return False
    End Function

    Private Function esVacia(ByVal exp As String) As Boolean
        'DEVUELVE TRUE SI UNA CADENA ES VACIA
        If String.IsNullOrEmpty(exp) Then
            Return True
        End If
        Return False
    End Function

    Private Function cantidadImplicitas() As Integer
        'DEVUELVE LA CANTIDAD DE TEXTOS QUE SON IMPLÍCITOS
        Dim ci As Integer = 0
        If esImplicita(txtNa.Text) Then
            ci += 1
        End If
        If esImplicita(txtNb.Text) Then
            ci += 1
        End If
        If esImplicita(txtCPIa.Text) Then
            ci += 1
        End If
        If esImplicita(txtCPIb.Text) Then
            ci += 1
        End If
        If esImplicita(txtFa.Text) Then
            ci += 1
        End If
        If esImplicita(txtFb.Text) Then
            ci += 1
        End If
        If esImplicita(txt_n_b_a.Text) Then
            ci += 1
        End If
        Return ci
    End Function

    Private Function cantidadVacias() As Integer
        'DEVUELVE LA CANTIDAD DE TEXTOX QUE SON VACÍOS
        Dim cv As Integer = 0
        If esVacia(txtNa.Text) Then
            cv += 1
        End If
        If esVacia(txtNb.Text) Then
            cv += 1
        End If
        If esVacia(txtCPIa.Text) Then
            cv += 1
        End If
        If esVacia(txtCPIb.Text) Then
            cv += 1
        End If
        If esVacia(txtFa.Text) Then
            cv += 1
        End If
        If esVacia(txtFb.Text) Then
            cv += 1
        End If
        If esVacia(txt_n_b_a.Text) Then
            cv += 1
        End If
        Return cv
    End Function

    Private Function cantidadNumeros() As Integer
        'DEVUELVE LA CANTIDAD DE TEXTOS QUE SON NUMÉRICAS (REAL)
        'LAS QUE NO ESTÁN VACÍAS NI SON ECUACIONES IMPLÍCITAS, SON NUMÉRICAS
        Return 7 - CantidadImplicitas() - CantidadVacias()
    End Function

    Private Function determinarCasoModelo() As Integer
        'EN DESARROLLO (NO TOCAR)

        Return -1
    End Function

#End Region

#Region "Eventos KeyChanged"
    Private Sub txtNa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNa.TextChanged
        validarFormato(txtNa, "NB")
    End Sub

    Private Sub txtNb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNb.TextChanged
        validarFormato(txtNb, "NA")
    End Sub

    Private Sub txtCPIa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCPIa.TextChanged
        validarFormato(txtCPIa, "CPIB")
    End Sub

    Private Sub txtCPIb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCPIb.TextChanged
        validarFormato(txtCPIb, "CPIA")
    End Sub

    Private Sub txtFa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFa.TextChanged
        validarFormato(txtFa, "FB")
    End Sub

    Private Sub txtFb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFb.TextChanged
        validarFormato(txtFb, "FA")
    End Sub

    Private Sub txt_n_b_a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_n_b_a.TextChanged
        validarFormato(txt_n_b_a, "")
    End Sub

#End Region

#Region "Evento boton Calcular"

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        If validarBalanceDatos() Then
            MsgBox("Bien hecho ")
        End If
    End Sub

#End Region




End Class
