' Códigos de error:
' -------------------------------------------------------------------------------------
' 000: Los datos tienen que cumplir con el formato especificado.
' 001: N% no puede ser implícita.
' 002: Los datos exceden la máxima cantidad de variables numéricas.
' 003: Los datos exceden la máxima cantidad de variables implícitas.
' 004: Los datos exceden la máxima cantidad de variables vacías.
' 005: Debe haber al menos una variable vacía.
' 006: Dos variables del mismo concepto no pueden ser implícitas.
' 007: Dos variables del mismo concepto no pueden ser vacías.
' 008: Dos variables del mismo concepto solamente pueden tener combinaciones de:
'      numérica-numérica
'      numérica-implícita
'      vacía-implícita
' 009: Los datos ingresados no tienen lógica matemática.


'ESTÁNDAR:
'----------------------------------------------------------------------------------------
'-NOMBRES DE FUNCIONES: EMPIEZAN POR MINÚSCULA, 
' Y LA PRIMER LETRA DE CADA PALABRA DIFERENTE EN MAYÚSCULA.
'-COLOCAR UN COMENTARIO DE LA FUNCIÓN QUE REALIZA CADA MÉTDODO

#Region "IMPORTS"
Imports System.Text.RegularExpressions
#End Region


Public Class frmPrincipal


#Region "Variables Globales"

    Dim __TXT__ERRORS__ As Integer = 0

#End Region

#Region "Eventos Form"

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim ev As New Evaluator()
        'ev.addVariable("NA", "2.2")
        'ev.Parse("2.2*NA + 3")
        'MsgBox(ev.Eval())
    End Sub

#End Region

#Region "Validaciones"

    Private Sub validarFormato(ByRef txt As TextBox, ByVal strVar As String)
        'VALIDA SI UN TEXTO TIENE EL FORMATO CORRECTO: NºREAL|NºREAL*VARIABLE
        '255; 192; 192 ROJO
        '192; 255; 192 VERDE
        '192; 255; 255 AZUL
        If Not Regex.IsMatch(txt.Text, "^(()|([0-9]{1,}(.[0-9]{1,})?(\*" & strVar & ")?))$") Then
            errSintaxisTxt.SetError(txt, IIf(strVar <> "", "El formato correcto es: N°REAL|N°REAL*" & strVar, "El formato correcto es: N°REAL"))
            txt.BackColor = Color.FromArgb(255, 255, 192, 192)
            txt.Tag = 1
            actualizarNumeroErrores()
        Else
            errSintaxisTxt.Clear()
            txt.Tag = 0
            actualizarNumeroErrores()
            If txt.Text <> "" Then
                txt.BackColor = Color.FromArgb(255, 192, 255, 192)
            Else
                txt.BackColor = Color.FromArgb(255, 255, 255, 255)
            End If
        End If
    End Sub

    Private Function validarBalanceDatos() As Boolean
        '   BALANCEAR LOS DATOS DE ENTRADA ES VALIDAR EL MÁXIMO Y MÍNIMO DE VARIABLES IMPLÍCITAS, VACÍAS, NUMÉRICAS PERMITIDAS 
        '   Y LAS SUMA DE TODAS LAS CANTIDADES DEBE SER IGUAL AL TOTAL DE VARIABLES.
        '   TOMANDO EN CUENTA QUE N% NUNCA DEBE SER IMPLÍCITA
        '   -------------------------------------------------
        '   MATEMÁTICAMENTE DENTRO DE LO POSIBLE:
        '   MÁXIMO IMPLÍCITAS: 3
        '   MÁXIMO NUMÉRICAS: 6
        '   MÁXIMO VACÍAS: 4
        '   MÍNIMO IMPLÍCITAS: 0
        '   MÍNIMO NUMÉRICAS: 0
        '   MÍNIMO VACÍAS: 1
        '   ------ DETALLE ----------------------------------
        '   6 NÚMEROS, 0 IMPLÍCITOS, 1 VACÍOS
        '   5 NÚMEROS, 1 IMPLÍCITOS, 1 VACÍOS
        '   4 NÚMEROS, 1 IMPLÍCITOS, 2 VACÍOS
        '   3 NÚMEROS, 2 IMPLÍCITOS, 2 VACÍOS
        '   2 NÚMEROS, 2 IMPLÍCITOS, 3 VACÍOS
        '   1 NÚMEROS, 3 IMPLÍCITOS, 3 VACÍOS
        '   0 NÚMEROS, 3 IMPLÍCITOS, 4 VACÍOS     'etc (no están todas las posibilidades)
        '   -------------------------------------------------

        '   VALIDANDO ERRORES

        If __TXT__ERRORS__ > 0 Then
            control_Error("000", "Los datos tienen que cumplir con el formato especificado.")
            Return False
        End If

        If esImplicita(txt_n_b_a.Text) Then
            control_Error("001", "N% no puede ser implícita.")
            Return False
        End If

        If cantidadNumeros() > 6 Then
            control_Error("002", "Los datos exceden la máxima cantidad de variables numéricas.")
            Return False
        End If

        If cantidadImplicitas() > 3 Then
            control_Error("003", "Los datos exceden la máxima cantidad de variables implícitas.")
            Return False
        End If

        If cantidadVacias() > 4 Then
            control_Error("004", "Los datos exceden la máxima cantidad de variables vacías.")
            Return False
        End If

        If cantidadVacias() < 1 Then
            control_Error("005", "Debe haber al menos una variable vacía.")
            Return False
        End If

        If esImplicita(txtNa.Text) And esImplicita(txtNb.Text) Then
            control_Error("006", "Dos variables del mismo concepto no pueden ser implícitas.")
            Return False
        ElseIf esImplicita(txtCPIa.Text) And esImplicita(txtCPIb.Text) Then
            control_Error("006", "Dos variables del mismo concepto no pueden ser implícitas.")
            Return False
        ElseIf esImplicita(txtFa.Text) And esImplicita(txtFb.Text) Then
            control_Error("006", "Dos variables del mismo concepto no pueden ser implícitas.")
            Return False
        End If

        If esVacia(txtNa.Text) And esVacia(txtNb.Text) Then
            control_Error("007", "Dos variables del mismo concepto no pueden ser vacías.")
            Return False
        ElseIf esVacia(txtCPIa.Text) And esVacia(txtCPIb.Text) Then
            control_Error("007", "Dos variables del mismo concepto no pueden ser vacías.")
            Return False
        ElseIf esVacia(txtFa.Text) And esVacia(txtFb.Text) Then
            control_Error("007", "Dos variables del mismo concepto no pueden ser vacías.")
            Return False
        End If

        If determinarCasoVariable(txtNa, txtNb) = 0 Then
            control_Error("008", "Dos variables del mismo concepto solamente pueden tener combinaciones de: Nuérica-Numérica, Numérica-Implícita, Vacía-Implícita (Sólo si N% es vacía) y Numérica-Vacía (Sólo si es la única vacía).")
            control_Error("009", "Los datos ingresados no tienen lógica matemática.")
            Return False
        End If

        If determinarCasoVariable(txtCPIa, txtCPIb) = 0 Then
            control_Error("008", "Dos variables del mismo concepto solamente pueden tener combinaciones de: Nuérica-Numérica, Numérica-Implícita, Vacía-Implícita (Sólo si N% es vacía) y Numérica-Vacía (Sólo si es la única vacía).")
            control_Error("009", "Los datos ingresados no tienen lógica matemática.")
            Return False
        End If

        If determinarCasoVariable(txtFa, txtFb) = 0 Then
            control_Error("008", "Dos variables del mismo concepto solamente pueden tener combinaciones de: Nuérica-Numérica, Numérica-Implícita, Vacía-Implícita (Sólo si N% es vacía) y Numérica-Vacía (Sólo si es la única vacía).")
            control_Error("009", "Los datos ingresados no tienen lógica matemática.")
            Return False
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

    Private Function esNumerica(ByVal exp As String) As Boolean
        'DEVUELVE TRUE SI UNA CADENA ES NUMÉRICA
        If Not esImplicita(exp) And Not esVacia(exp) Then
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
        Return 7 - cantidadImplicitas() - cantidadVacias()
    End Function

    Private Sub actualizarNumeroErrores()
        'SETEA LA CANTIDAD DE TEXTOX QUE TIENEN ERROR EN __TXT__ERRORS__
        Dim ce As Integer = 0
        If txtNa.Tag = 1 Then
            ce += 1
        End If
        If txtNb.Tag = 1 Then
            ce += 1
        End If
        If txtCPIa.Tag = 1 Then
            ce += 1
        End If
        If txtCPIb.Tag = 1 Then
            ce += 1
        End If
        If txtFa.Tag = 1 Then
            ce += 1
        End If
        If txtFb.Tag = 1 Then
            ce += 1
        End If
        If txt_n_b_a.Tag = 1 Then
            ce += 1
        End If
        __TXT__ERRORS__ = ce
    End Sub

    Private Sub control_Error(ByVal cod As String, ByVal mensaje As String)
        MsgBox("Error " & cod & ": " & mensaje, vbCritical, "Error número: " & cod)
    End Sub

    Private Function determinarCasoVariable(ByRef txt1 As TextBox, ByRef txt2 As TextBox) As Integer
        ' DEVUELVE EL CÓDIGO DE CASO DE PAREO DE VARIABLES DE MISMO CONCEPTO
        ' ------------------------------------------------------------------
        ' CÓDIGOS
        ' ------------------------------------------------------------------
        ' 0 | NO ES POSIBLE
        ' 1 | NUMÉRICA - VACÍA
        ' 2 | VACÍA - NUMÉRICA
        ' 3 | NUMÉRICA - NUMÉRICA
        ' 4 | IMPLÍCITA - NUMÉRICA
        ' 5 | NUMÉRICA - IMPLÍCITA
        ' 6 | VACÍA - IMPLÍCITA
        ' 7 | IMPLÍCITA - VACÍA

        If Not (esImplicita(txt1.Text) And esVacia(txt2.Text) And esVacia(txt_n_b_a.Text)) Then
            If Not (esVacia(txt1.Text) And esImplicita(txt2.Text) And esVacia(txt_n_b_a.Text)) Then
                If Not (esNumerica(txt1.Text) And esImplicita(txt2.Text)) Then
                    If Not (esImplicita(txt1.Text) And esNumerica(txt2.Text)) Then
                        If Not (esNumerica(txt1.Text) And esNumerica(txt2.Text)) Then
                            If Not (esVacia(txt1.Text) And esNumerica(txt2.Text) And cantidadVacias() = 1) Then
                                If Not (esNumerica(txt1.Text) And esVacia(txt2.Text) And cantidadVacias() = 1) Then
                                    Return 0
                                End If
                                Return 1
                            End If
                            Return 2
                        End If
                        Return 3
                    End If
                    Return 4
                End If
                Return 5
            End If
            Return 6
        End If
        Return 7
    End Function

    Public Sub actualizarCasoModelo()
        'ACTUALIZA EL CASO DEL MODELO (CONCATENAR LOS CASOS DE CADA VARIABLE EN UN SOLO CASO. EJ: 7360)
        'EL ÚLTIMO DÍGITO SIGNIFICA: 1 = N% VACÍA; 0 = N% LLENA
        Dim caso As String = ""
        caso = determinarCasoVariable(txtNa, txtNb) & determinarCasoVariable(txtCPIa, txtCPIb)
        caso &= determinarCasoVariable(txtFa, txtFb) & IIf(esVacia(txt_n_b_a.Text), 1, 0)
        mdModelo.sCaso = caso
    End Sub

    Public Function detectarPrimerVacia() As String
        'DEVUELVE EL NOMBRE DE LA PRIMER VARIABLE QUE SE ENCUENTRA VACÍA AL RECORRER DE ARRIBA HACIA ABAJO
        If esVacia(txtNa.Text) Then
            Return "NA"
        End If
        If esVacia(txtNb.Text) Then
            Return "NB"
        End If
        If esVacia(txtCPIa.Text) Then
            Return "CPIA"
        End If
        If esVacia(txtCPIb.Text) Then
            Return "CPIB"
        End If
        If esVacia(txtFa.Text) Then
            Return "FA"
        End If
        If esVacia(txtFb.Text) Then
            Return "FB"
        End If
        Return ""
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
            'PRECALCULAR
            mdModelo.Precalcular()
            'CALCULAR
            mdModelo.Calcular()
        End If
    End Sub

#End Region



End Class


#Region "INTEGRANTES"
' INTEGRANTES:
' ---------------------------------------
' FRANCO UGARTE
' MARÍA ESTEHR GRANADOS
' TATIANA CONTRERAS
' SULEYKA JUÁREZ
' PABLO AGUILAR
#End Region
