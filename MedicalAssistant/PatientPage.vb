Imports System.Data.SqlTypes
Imports System.Globalization
Imports System.Threading
Public Class PatientPage
    Public patients As New List(Of Patient)
    Private Addp As Integer = -1
    Public madechanges As Boolean = False
    Public labels As New List(Of LinkLabel)
    Public icons As New List(Of PictureBox)
    Private initialrow As Integer = 130
    Private RowIter As Integer = 100
    Public Temppatient As New Patient
    Private password As String = ""
    Private columns As New List(Of Integer)
    Private columnsicons As New List(Of Integer)
    Private max As Integer = 0
    Sub New(ByRef InPatients As List(Of Patient), Optional addPat As Integer = -1, Optional password As String = "")
        'Initialise pass for save and addp for indexing (add or edit patient)
        patients = InPatients
        Me.password = password
        Addp = addPat

        'Call all components
        InitializeComponent()
        Me.Text = Language.Form_Name_Patient(Language.Selectedlanguage)
        'Initialize any components value
        Initialize_Label_ICONS_Dimentions()
        Initialize_Add_Edit()
        intantiate_Language()
    End Sub

#Region "Initialize Components"



    Private Sub Initialize_Label_ICONS_Dimentions()
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        If screenWidth > 1650 Then
            max = 1

        End If
        If max = 1 Then
            For i As Integer = 0 To 1
                columns.Add(80 + i * 500)
                columnsicons.Add(30 + i * 500)
            Next
        Else
            columns.Add(80)
            columnsicons.Add(30)
        End If
    End Sub

    Private Sub Initialize_Add_Edit()
        If Addp <> -1 Then
            'User wants to edit
            Temppatient = patients(Addp)
            Button3.Visible = True
            TextBox1.Text = patients(Addp).Name
            TextBox2.Text = patients(Addp).SurName
            DateTimePicker1.Value = patients(Addp).birthdate
            TextBox3.Text = patients(Addp).Amka
            TextBox4.Text = patients(Addp).PhoneNumber
            intstanciate(patients(Addp))
        Else
            'User wants to Add
            LinkLabel1.Visible = False
            PictureBox1.Visible = False
            Button3.Visible = False
        End If
    End Sub



    Private Sub intantiate_Language()
        Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture
        Button1.Text = Language.save_Translations(Language.Selectedlanguage)
        Button2.Text = Language.back_Translations(Language.Selectedlanguage)
        Button3.Text = Language.delete_Translations(Language.Selectedlanguage)
        Label1.Text = Language.Name(Language.Selectedlanguage)
        Label2.Text = Language.Surname(Language.Selectedlanguage)
        Label3.Text = Language.AMKA(Language.Selectedlanguage)
        Label4.Text = Language.Birth_Date(Language.Selectedlanguage)
        Label5.Text = Language.Telephone_Number(Language.Selectedlanguage)
        Label6.Text = Language.Add_Visit(Language.Selectedlanguage)
    End Sub


#End Region

#Region "Buttons close form (save-back-delete)"

    'save
    Private Sub SaveClick(sender As Object, e As EventArgs) Handles Button1.Click
        madechanges = True

        Dim patientin As New Patient(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value, TextBox3.Text, TextBox4.Text)

        If (Addp = -1) Then
            patients.Add(patientin)
        Else
            patients(Addp).Amka = patientin.Amka
            patients(Addp).birthdate = patientin.birthdate
            patients(Addp).SurName = patientin.SurName
            patients(Addp).Name = patientin.Name
            patients(Addp).PhoneNumber = patientin.PhoneNumber
        End If
        Me.Close()
    End Sub


    'back
    Private Sub BackClick(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    'delete
    Private Sub DeleteClick(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult
        result = MessageBox.Show("Διαγραφή ασθενή; ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If Addp <> -1 Then
                patients.Remove(patients(Addp))
                madechanges = True
                Me.Close()
            End If
        End If

    End Sub
#End Region

#Region "Initialize Labels-Icons (appointments)"

    Private Sub intstanciate(patient As Patient)
        removeComponents()
        Dim columnnumber As Integer = 0
        Dim rownumber As Integer = 0
        Dim iteration As Integer = 0

        Dim SearchVisitations As List(Of Patient_Visitation) = shortvisitations(patient.Visitations)

        Dim VisitationscOUNTER As Integer = patient.Visitations.Count

        If (SearchVisitations.Count > 0) Then
            LinkLabel1.Visible = True
            PictureBox1.Visible = True
            LinkLabel1.Text = SearchVisitations(iteration).VisitationDate.ToString
            iteration += 1
            VisitationscOUNTER -= 1
            If max = 1 Then
                columnnumber += 1
            End If

        Else
            LinkLabel1.Visible = False
            PictureBox1.Visible = False
        End If
        While VisitationscOUNTER > 0
            Dim LocationxLabel As Integer = columns(columnnumber)
            Dim LocationxIcon As Integer = columnsicons(columnnumber)
            Dim LocationY As Integer = RowIter * rownumber + initialrow
            addlabel(LocationxLabel, LocationY, SearchVisitations(iteration).VisitationDate.ToString)
            iteration += 1
            AddPictureBox(LocationxIcon, LocationY)
            VisitationscOUNTER -= 1
            If max = 1 Then
                If columnnumber <> 0 Then
                    columnnumber = 0
                    rownumber += 1
                Else
                    columnnumber = 1
                End If
            Else
                rownumber += 1
            End If

        End While

    End Sub


    Private Sub removeComponents()

        If labels.Count > 0 Then

            If labels.Count > 1 Then
                For i As Integer = 0 To labels.Count - 1
                    Me.Controls.Remove(labels(i))
                    labels(i).Dispose()
                Next
                For i As Integer = 0 To icons.Count - 1
                    Me.Controls.Remove(icons(i))
                    icons(i).Dispose()
                Next

            End If


        End If
    End Sub


    Private Function shortvisitations(Input As List(Of Patient_Visitation))
        Dim SearchVisitations As List(Of Patient_Visitation) = Input.OrderByDescending(Function(v) v.VisitationDate).ToList()
        Return SearchVisitations
    End Function

    Private Sub addlabel(locationX As Integer, locationY As Integer, labelstring As String)
        Dim newLinkLabel As New LinkLabel()
        newLinkLabel.Text = labelstring
        newLinkLabel.LinkColor = LinkLabel1.LinkColor
        newLinkLabel.Font = LinkLabel1.Font

        newLinkLabel.AutoSize = True
        newLinkLabel.Location = New Point(locationX, locationY)
        AddHandler newLinkLabel.LinkClicked, AddressOf LinkLabelClicked
        labels.Add(newLinkLabel)
        Panel24.Controls.Add(labels(labels.Count - 1))

    End Sub

    Private Sub AddPictureBox(locationX As Integer, locationY As Integer)
        Dim newPictureBox As New PictureBox()
        newPictureBox.BackgroundImage = PictureBox1.BackgroundImage
        newPictureBox.Size = PictureBox1.Size
        newPictureBox.BackgroundImageLayout = PictureBox1.BackgroundImageLayout
        newPictureBox.SizeMode = PictureBox1.SizeMode
        newPictureBox.Location = New Point(locationX, locationY)

        icons.Add(newPictureBox)
        Panel24.Controls.Add(icons(icons.Count - 1))
    End Sub
#End Region

#Region "Add Visitation"
    Private Sub BTN_Add_Click(sender As Object, e As EventArgs) Handles BTN_Add.Click, Label6.Click
        Dim madechanges As Boolean = False
        If Addp = -1 Then
            Dim patientin As New Patient(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value, TextBox3.Text, TextBox4.Text)
            patients.Add(patientin)
            Addp = patients.Count - 1
        End If
        Using invadd As New VisitationPage(patients(Addp).Visitations)
            invadd.ShowDialog()
            invadd.Hide()
            SaveLoad.SavePatientsToJson("patients.json", patients, password)
        End Using
        intstanciate(patients(Addp))
    End Sub


#End Region

#Region "Edit Visitation"
    Private Sub LinkLabelClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Name As String = DirectCast(sender, LinkLabel).Text
        ' You can also call another function here
        OpenvISITATION(Name)
    End Sub

    Private Sub OpenvISITATION(name As String)
        For i As Integer = 0 To patients(Addp).Visitations.Count - 1

            If patients(Addp).Visitations(i).VisitationDate.ToString = name Then

                Dim useradd As New VisitationPage(patients(Addp).Visitations, i)

                useradd.ShowDialog()
                patients(Addp).Visitations = useradd.PatVisitation
                If (useradd.madechanges) Then

                    SaveLoad.SavePatientsToJson("patients.json", patients, password)
                    intstanciate(patients(Addp))
                    Exit For
                End If

            End If



        Next


    End Sub

#End Region



End Class