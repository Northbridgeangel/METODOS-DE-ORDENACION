Public Class Form1
    Dim DESORDEN(1000) As String
    Dim ORDEN(1000) As String
    Dim POSI As Integer
    Dim MINIMO As String
    Dim AUXILIAR As String
    Dim AUXILIAR1 As String
    Dim CUANTASLETRAS As Integer
    Public RESULTADO As Integer

    Private Sub BTN_CARGA_NºS_Click(sender As Object, e As EventArgs) Handles BTN_CARGA_NºS.Click
        ' FASE 1 VECTOR "DESORDEN(1000)" Y CARGA DEL COMBOBOX NUMEROS AL TUN TUN 
        'Dim DESORDEN(1000) As Integer
        'Dim ORDEN(1000) As Integer

        'Dim MINIMO As Integer



        Randomize()
        For I = 1 To 1000
            'DESORDEN(I) = Int(Rnd() * 4999 + 1)
            AUXILIAR = Chr(Int(Rnd() * 26 + 65))
            CUANTASLETRAS = Int(Rnd() * 5 + 1)
            For X = 1 To CUANTASLETRAS
                AUXILIAR1 = AUXILIAR1 + AUXILIAR

            Next
            DESORDEN(I) = AUXILIAR1
            AUXILIAR = ""
            AUXILIAR1 = ""
            CMBX_DESORDEN.Items.Add(DESORDEN(I))

        Next
        'DESORDEN(I)= Chr(Int(Rnd()*26+65))

        ' FASE 2 ORDENACIÓN POR BURBUJA
        For I = 1 To 1000
            'MINIMO = 9999
            MINIMO = "@"
            POSI = 0
            For X = 1 To 1000
                If DESORDEN(X) > MINIMO Then
                    'If DESORDEN(X) < MINIMO Then
                    MINIMO = DESORDEN(X)
                    POSI = X
                End If
            Next
            ORDEN(I) = MINIMO
            DESORDEN(POSI) = "@"

        Next

        ' FASE 3 CARGAR EN COMBOBOX ORDEN EL VECTOR ORDEN
        For I = 1 To 1000
            CMBX_ORDEN.Items.Add(ORDEN(I))
        Next
        For I = 1 To 1000
            ComboBox1.Items.Add((DESORDEN(I)))
        Next

    End Sub

    Private Sub BTN_REINICIA_Click(sender As Object, e As EventArgs) Handles BTN_REINICIA.Click
        CMBX_DESORDEN.Items.Clear()
        CMBX_ORDEN.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CONTADOR As Integer
        Dim CONTADORVOCALES As Integer
        Dim LETRA As Char
        For I = 1 To 1000
            CONTADOR = CONTADOR + Len(ORDEN(I))
            LETRA = Microsoft.VisualBasic.Left(ORDEN(I), 1)
            If LETRA = "A" Or LETRA = "E" Or LETRA = "O" Or LETRA = "I" Or LETRA = "U" Then CONTADORVOCALES = CONTADORVOCALES + Len(ORDEN(I))
        Next
        MsgBox("HAY " & CONTADOR & " LETRAS DE LAS CUALES " & CONTADORVOCALES & " SON VOCALES")
    End Sub



    ' Private Sub BTN_QUICKSORT_Click(sender As Object, e As EventArgs) Handles BTN_QUICKSORT.Click
    '*********************************************************************************************
    'QUICKSHORT
    '*********************************************************************************************
    'Cursor.Current = Cursors.WaitCursor
    'ReDim DESORDEN(1000)
    'ReDim ORDEN(1000)
    'CMBX_DESORDEN.Items.Clear()
    ' CMBX_ORDEN.Items.Clear()
    'Randomize()
    'For X = 1 To 1000
    ' DESORDEN(X) = Int(Rnd() * 4999 + 1)
    ' CMBX_ORDEN.Items.Add(DESORDEN(X))
    'Next

    '2 FASE LLAMADA A LA FUNCIÓN
    'Call Ordenar_Matriz(DESORDEN, LBound(DESORDEN), UBound(DESORDEN))

    '3 FASE LLAMADA A LA FUNCIÓN
    'For I = 1 To 1000
    'CMBX_ORDEN.Items.Add(DESORDEN(I))
    'ORDEN = DESORDEN(I)
    'Next

    ' End Sub



    '*********************************************************************************************
    'PROGRAMA QUE ME PIDE UNA PALABRA Y LA METE EN UNA POSICIÓN DEL VECTOR
    '*********************************************************************************************
    Private Sub BTN_MIDEFRASE_Click(sender As Object, e As EventArgs) Handles BTN_MIDEFRASE.Click
        Dim PALABRA() As Char
        Dim TEXTO As String
        Dim MIDE As Integer
        Dim LETRA As Char

        TEXTO = InputBox("METE FRASE")
        MIDE = Len(TEXTO)


        ReDim PALABRA(MIDE)
        For I = 1 To MIDE
            LETRA = Mid(TEXTO, I, 1)
            PALABRA(I) = LETRA
            ComboBox2.Items.Add(PALABRA(I))
        Next

    End Sub

    Private Sub BTN_AREA_Click(sender As Object, e As EventArgs) Handles BTN_AREA.Click
        Dim B, A As Integer
        B = InputBox("METE BASE")
        A = InputBox("METE ALTURA")
        Call AREA(B, A)
        MsgBox(RESULTADO)
    End Sub
    Sub AREA(BB As Integer, AA As Integer)
        RESULTADO = BB * AA / 2
    End Sub
End Class
