Public Class LanguageSelectionPage
    Public selectedlanguage As Integer = -1

    Sub New()

        InitializeComponent()

        intializeLanguages()
    End Sub

    Private Sub intializeLanguages()
        ComboBox1.Items.Clear()
        For i As Integer = 0 To Language.LanguagesNames.GetLength(0) - 1
            ComboBox1.Items.Add(Language.LanguagesNames(i, 1))
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selectedlanguage = ComboBox1.SelectedIndex
        Me.Close()
    End Sub


End Class