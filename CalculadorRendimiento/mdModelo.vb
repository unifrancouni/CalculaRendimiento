
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
' ENTRE CODIGOS COMPATIBLES Y NO COMPATIBLES HAY 7^3 CASOS (CODIGOS DE 3 DIGITOS, DEBIDO A LOS 3 PARES DE VARIABLES)
' SOLO COMPATIBLES SON 179 CASOS QUE RESULTA DE (5^5)+2(3^3)
' YA QUE LOS INCOMPATIBLES SON LOS 1'S Y 2'S REPETIDOS Y LAS COMBINACIONES DE [1 2]x[6 7]


'ESTÁNDAR:
'----------------------------------------------------------------------------------------
'-NOMBRES DE FUNCIONES: EMPIEZAN POR MINÚSCULA, 
' Y LA PRIMER LETRA DE CADA PALABRA DIFERENTE EN MAYÚSCULA.
'-COLOCAR UN COMENTARIO DE LA FUNCIÓN QUE REALIZA CADA MÉTDODO

Module mdModelo

    'EN ÉSTE MÓDULO SE DESARROLLARÁN LAS FUNCIONES O MÉTODOS DEL PROGRAMA COMO TAL
    'EN POCAS PALABRAS EL CORAZÓN DE LA APP
    'LAS ECUACIONES, LOS DESPEJES, LAS SUSTITUCIONES, LOS CASOS MATEMÁTICOS

    Public sCaso As String

#Region "Obtención de Casos"
    Private Function obtenerCasoN() As Integer
        If Len(sCaso) = 4 Then
            Return CInt(Mid(sCaso, 1, 1))
        End If
        Return -1
    End Function

    Public Function obtenerCasoCPI() As Integer
        If Len(sCaso) = 4 Then
            Return CInt(Mid(sCaso, 2, 1))
        End If
        Return -1
    End Function

    Public Function obtenerCasoF() As Integer
        If Len(sCaso) = 4 Then
            Return CInt(Mid(sCaso, 3, 1))
        End If
        Return -1
    End Function

    Private Function obtenerEstadoNBA() As Integer
        If Len(sCaso) = 4 Then
            Return CInt(Mid(sCaso, 2, 1))
        End If
        Return -1
    End Function
#End Region

    Public Sub Precalcular()
        'REALIZA CÁLCULOS CUANDO LA ENTRADA DE LOS DATOS ES INDIRECTA 
        'Y CALCULABLE SIN NECESIDAD DE LA FÓRMULA GENERAL. (CASO 4 Ó 5)

        frmPrincipal.actualizarCasoModelo() 'ACTUALIZAR CASO DE VARIABLES SEGUN DATOS EN LOS TEXTBOX'S

        'PRECALCULANDO N EN CASO TENGA CASOS 4 Ó 5
        If obtenerCasoN() = 4 Then 'NA ES IMPLÍCITA
            frmPrincipal.txtNa.Text = metodoSustitucionNumerica("NB", frmPrincipal.txtNb.Text, frmPrincipal.txtNa.Text)
            frmPrincipal.txtNa.BackColor = Color.Gainsboro
        ElseIf obtenerCasoN() = 5 Then 'NB ES IMPLÍCITA
            frmPrincipal.txtNb.Text = metodoSustitucionNumerica("NA", frmPrincipal.txtNa.Text, frmPrincipal.txtNb.Text)
            frmPrincipal.txtNb.BackColor = Color.Gainsboro
        End If

        'PRECALCULANDO CPI EN CASO TENGA CASOS 4 Ó 5
        If obtenerCasoCPI() = 4 Then 'CPIA ES IMPLÍCITA
            frmPrincipal.txtCPIa.Text = metodoSustitucionNumerica("CPIB", frmPrincipal.txtCPIb.Text, frmPrincipal.txtCPIa.Text)
            frmPrincipal.txtCPIa.BackColor = Color.Gainsboro
        ElseIf obtenerCasoCPI() = 5 Then 'CPIB ES IMPLÍCITA
            frmPrincipal.txtCPIb.Text = metodoSustitucionNumerica("CPIA", frmPrincipal.txtCPIa.Text, frmPrincipal.txtCPIb.Text)
            frmPrincipal.txtCPIb.BackColor = Color.Gainsboro
        End If

        'PRECALCULANDO F EN CASO TENGA CASOS 4 Ó 5
        If obtenerCasoF() = 4 Then 'FA ES IMPLÍCITA
            frmPrincipal.txtFa.Text = metodoSustitucionNumerica("FB", frmPrincipal.txtFb.Text, frmPrincipal.txtFa.Text)
            frmPrincipal.txtFa.BackColor = Color.Gainsboro
        ElseIf obtenerCasoF() = 5 Then 'FB ES IMPLÍCITA
            frmPrincipal.txtFb.Text = metodoSustitucionNumerica("FA", frmPrincipal.txtFa.Text, frmPrincipal.txtFb.Text)
            frmPrincipal.txtFb.BackColor = Color.Gainsboro
        End If

        frmPrincipal.actualizarCasoModelo()

    End Sub

    Public Sub Calcular()
        Do
            frmPrincipal.actualizarCasoModeloSinValidar()
            If sCaso = "3338" Then
                'SI TODOS LOS DATOS SON NUMÉRICOS, EXCEPTO N%, CALCULAR N%
                frmPrincipal.txt_n_b_a.Text = obtenerResultadoEcDespejada("NBA", False)
                frmPrincipal.txt_n_b_a.BackColor = Color.Gainsboro
            ElseIf sCaso.Contains("1") Or sCaso.Contains("2") Then
                'CALCULAR VARIABLE FALTANTE CUANDO SON NUMÉRICAS
                'ENTONCES ASUMIMOS QUE EL RESTO DE VARIABLES TIENEN CASOS UNICAMENTE 3 (N-N)
                Dim nVariable As String = detectarVariableFaltante()
                If nVariable = "NA" Then
                    frmPrincipal.txtNa.Text = obtenerResultadoEcDespejada("NA", False)
                    frmPrincipal.txtNa.BackColor = Color.Gainsboro
                ElseIf nVariable = "NB" Then
                    frmPrincipal.txtNb.Text = obtenerResultadoEcDespejada("NB", False)
                    frmPrincipal.txtNb.BackColor = Color.Gainsboro
                ElseIf nVariable = "CPIA" Then
                    frmPrincipal.txtCPIa.Text = obtenerResultadoEcDespejada("CPIA", False)
                    frmPrincipal.txtCPIa.BackColor = Color.Gainsboro
                ElseIf nVariable = "CPIB" Then
                    frmPrincipal.txtCPIb.Text = obtenerResultadoEcDespejada("CPIB", False)
                    frmPrincipal.txtCPIb.BackColor = Color.Gainsboro
                ElseIf nVariable = "FA" Then
                    frmPrincipal.txtFa.Text = obtenerResultadoEcDespejada("FA", False)
                    frmPrincipal.txtFa.BackColor = Color.Gainsboro
                ElseIf nVariable = "FB" Then
                    frmPrincipal.txtFb.Text = obtenerResultadoEcDespejada("FB", False)
                    frmPrincipal.txtFb.BackColor = Color.Gainsboro
                End If
            ElseIf sCaso.Contains("6") Or sCaso.Contains("7") Then
                If obtenerEstadoNBA() = 8 Then
                    'DEBEMOS CALCULAR N% SUSTITUYENDO VARIABLES NO CALCULADAS POR UN VALOR NUMÉRICO '1'
                    frmPrincipal.txt_n_b_a.Text = obtenerResultadoEcDespejada("NBA", True)
                    frmPrincipal.txt_n_b_a.BackColor = Color.Gainsboro
                ElseIf obtenerEstadoNBA() = 9 Then
                    'AQUI VAMOS A CALCULAR LA VARIABLE QUE FALTE (LA PRIMERA QUE SE ENCUENTRE) Y ASÍ CÍCLICAMENTE

                End If
            End If
            frmPrincipal.actualizarCasoModeloSinValidar()
        Loop Until sCaso = "3339"
    End Sub

    Private Function metodoSustitucionNumerica(ByVal nomVar As String, ByVal valVar As String, ByVal exp As String) As String
        Dim ev As New clEvaluator()
        ev.addVariable(nomVar, valVar)
        ev.Parse(exp)
        Return ev.Eval()
    End Function

    Private Function ecNa() As String
        Return "((NBA)/(100)+1)*((NB*CPIB*FA)/(CPIA*FB))"
    End Function
    Private Function ecNb() As String
        Return "(NA*CPIA*FB)/(((NBA)/(100)+1)*(CPIB*FA))"
    End Function
    Private Function ecCPIa() As String
        Return "((NBA)/(100)+1)*((NB*CPIB*FA)/(NA*FB))"
    End Function
    Private Function ecCPIb() As String
        Return "(NA*CPIA*FB)/(((NBA)/(100)+1)*(NB*FA))"
    End Function
    Private Function ecFa() As String
        Return "(NA*CPIA*FB)/(((NBA)/(100)+1)*(NB*CPIB))"
    End Function
    Private Function ecFb() As String
        Return "((NBA)/(100)+1)*((NB*CPIB*FA)/(NA*CPIA))"
    End Function
    Private Function ecNBA() As String
        Return "((NA*CPIA*FB)/(NB*CPIB*FA)-1)*100"
    End Function

    Private Function detectarVariableFaltante() As String
        'CUANDO EL CASO INVOLUCRA 1 Ó 2, SE DETECTA CUAL ES LA ÚNICA VACÍA PARA POSTERIOR CÁLCULO SENCILLO
        Return frmPrincipal.detectarPrimerVacia()
    End Function

    Private Function obtenerResultadoEcDespejada(ByVal nVar As String, ByVal nCambioVar As Boolean) As String
        'CALCULA LA VARIABLE 'nVar' EN FUNCIÓN DE SU ECUACIÓN DESPEJADA
        'SI 'nCambioVar' ES TRUE, SE CAMBIAN LAS VARIABLES NO CALCULADAS POR '1'

        Dim ev As New clEvaluator()

        If nCambioVar = False Then
            If nVar = "NA" Then
                agregarVariable("NBA", ev)
                agregarVariable("NB", ev)
                agregarVariable("CPIA", ev)
                agregarVariable("CPIB", ev)
                agregarVariable("FA", ev)
                agregarVariable("FB", ev)
                ev.Parse(ecNa())
            ElseIf nVar = "NB" Then
                agregarVariable("NBA", ev)
                agregarVariable("NA", ev)
                agregarVariable("CPIA", ev)
                agregarVariable("CPIB", ev)
                agregarVariable("FA", ev)
                agregarVariable("FB", ev)
                ev.Parse(ecNb())
            ElseIf nVar = "CPIA" Then
                agregarVariable("NBA", ev)
                agregarVariable("NA", ev)
                agregarVariable("NB", ev)
                agregarVariable("CPIB", ev)
                agregarVariable("FA", ev)
                agregarVariable("FB", ev)
                ev.Parse(ecCPIa())
            ElseIf nVar = "CPIB" Then
                agregarVariable("NBA", ev)
                agregarVariable("NA", ev)
                agregarVariable("NB", ev)
                agregarVariable("CPIA", ev)
                agregarVariable("FA", ev)
                agregarVariable("FB", ev)
                ev.Parse(ecCPIb())
            ElseIf nVar = "FA" Then
                agregarVariable("NBA", ev)
                agregarVariable("NA", ev)
                agregarVariable("NB", ev)
                agregarVariable("CPIA", ev)
                agregarVariable("CPIB", ev)
                agregarVariable("FB", ev)
                ev.Parse(ecFa())
            ElseIf nVar = "FB" Then
                agregarVariable("NBA", ev)
                agregarVariable("NA", ev)
                agregarVariable("NB", ev)
                agregarVariable("CPIA", ev)
                agregarVariable("CPIB", ev)
                agregarVariable("FA", ev)
                ev.Parse(ecFb())
            ElseIf nVar = "NBA" Then
                agregarVariable("NA", ev)
                agregarVariable("NB", ev)
                agregarVariable("CPIA", ev)
                agregarVariable("CPIB", ev)
                agregarVariable("FA", ev)
                agregarVariable("FB", ev)
                ev.Parse(ecNBA())
            End If
        Else
            Dim l As List(Of String)
            Dim ecuacion As String
            If nVar = "NBA" Then
                'PRESUSTITUCION
                ecuacion = ecNBA()
                ecuacion = Presustituir(ecuacion)
                l = frmPrincipal.detectarVariablesNoCalculadas()
                For i = 0 To l.Count - 1
                    If l(i) <> nVar Then
                        agregarVariableSustituida(l(i), ev)
                    End If
                Next
                ev.Parse(ecuacion)
            End If
        End If

        Return ev.Eval()

    End Function

    Public Sub agregarVariable(ByVal nVar As String, ByRef ev As clEvaluator)
        If nVar = "NA" Then
            ev.addVariable("NA", frmPrincipal.txtNa.Text)
        ElseIf nVar = "NB" Then
            ev.addVariable("NB", frmPrincipal.txtNb.Text)
        ElseIf nVar = "CPIA" Then
            ev.addVariable("CPIA", frmPrincipal.txtCPIa.Text)
        ElseIf nVar = "CPIB" Then
            ev.addVariable("CPIB", frmPrincipal.txtCPIb.Text)
        ElseIf nVar = "FA" Then
            ev.addVariable("FA", frmPrincipal.txtFa.Text)
        ElseIf nVar = "FB" Then
            ev.addVariable("FB", frmPrincipal.txtFb.Text)
        ElseIf nVar = "NBA" Then
            ev.addVariable("NBA", frmPrincipal.txt_n_b_a.Text)
        End If
    End Sub

    Public Sub agregarVariableSustituida(ByVal nVar As String, ByRef ev As clEvaluator)
        ev.addVariable(nVar, "1")
    End Sub

    Private Function Presustituir(ByVal ec As String) As String
        If Not frmPrincipal.esVacia(frmPrincipal.txtNa.Text) Then
            ec = ec.Replace("NA", frmPrincipal.txtNa.Text)
        End If
        If Not frmPrincipal.esVacia(frmPrincipal.txtNb.Text) Then
            ec = ec.Replace("NB", frmPrincipal.txtNb.Text)
        End If
        If Not frmPrincipal.esVacia(frmPrincipal.txtCPIa.Text) Then
            ec = ec.Replace("CPIA", frmPrincipal.txtCPIa.Text)
        End If
        If Not frmPrincipal.esVacia(frmPrincipal.txtCPIb.Text) Then
            ec = ec.Replace("CPIB", frmPrincipal.txtCPIb.Text)
        End If
        If Not frmPrincipal.esVacia(frmPrincipal.txtFa.Text) Then
            ec = ec.Replace("FA", frmPrincipal.txtFa.Text)
        End If
        If Not frmPrincipal.esVacia(frmPrincipal.txtFb.Text) Then
            ec = ec.Replace("FB", frmPrincipal.txtFb.Text)
        End If
        Return ec
    End Function


End Module



#Region "INTEGRANTES"
' INTEGRANTES:
' ---------------------------------------
' FRANCO UGARTE
' MARÍA ESTEHR GRANADOS
' TATIANA CONTRERAS
' SULEYKA JUÁREZ
' PABLO AGUILAR
#End Region