Imports System.Collections.Generic
Imports System.Globalization
Imports System.Reflection.Emit
Imports System.Threading

Public Class VisitationPage
    Public PatVisitation As New List(Of Patient_Visitation)
    Public Indexing As Integer = -1
    Public madechanges As Boolean = False

    Sub New(ByRef Visitations As List(Of Patient_Visitation), Optional index As Integer = -1)

        InitializeComponent()
        'INDEX >-1 Then we have opened a value
        Indexing = index
        If (Indexing <> -1) Then
            Button3.Visible = True
            GetValues(Visitations(Indexing))
        End If
        PatVisitation = Visitations
        intantiate_Language()
    End Sub
    Private Sub intantiate_Language()
        Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture
        Button1.Text = Language.save_Translations(Language.Selectedlanguage)
        Button2.Text = Language.back_Translations(Language.Selectedlanguage)
        Button3.Text = Language.delete_Translations(Language.Selectedlanguage)
        Label1.Text = Language.Diagnosis_Progress(Language.Selectedlanguage)
        Label2.Text = Language.Medication(Language.Selectedlanguage)
        Label3.Text = Language.Date_v(Language.Selectedlanguage)


    End Sub


    Private Sub GetValues(Visitation As Patient_Visitation)
        RichTextBox1.Text = Visitation.Diagn_poreia
        RichTextBox2.Text = Visitation.farmakeutikhagwgh
        DateTimePicker1.Value = Visitation.VisitationDate
    End Sub

    Private Sub back_click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Save_click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TempVisitation As New Patient_Visitation(DateTimePicker1.Value, RichTextBox1.Text, RichTextBox2.Text)
        If Indexing > -1 Then
            PatVisitation(Indexing) = TempVisitation
        Else
            PatVisitation.Add(TempVisitation)
        End If
        madechanges = True
        Me.Close()

    End Sub



    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Indexing > -1 Then
            PatVisitation.Remove(PatVisitation(Indexing))
            madechanges = True
        End If

        Me.Close()
    End Sub


End Class