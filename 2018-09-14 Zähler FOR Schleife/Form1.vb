Public Class Form1
    Dim mAnfang As Integer
    Dim mEnde As Integer
    Dim mSchritt As Integer

    Private Sub cmdZähler_Click(sender As Object, e As EventArgs) Handles cmdZähler.Click

        Dim mA As Integer
        For mA = mAnfang To mEnde Step mSchritt
            MsgBox(mA)
        Next
        MsgBox("Ende")

    End Sub

    Private Sub cmdEingabe_Click(sender As Object, e As EventArgs) Handles cmdEingabe.Click


        mAnfang = InputBox("Anfang eingeben:")
        mEnde = InputBox("Ende eingeben:")
        mSchritt = InputBox("Schritte eingeben:")
    End Sub
End Class
