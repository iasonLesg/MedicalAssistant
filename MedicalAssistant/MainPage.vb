Imports System.Collections.Generic
Imports System.IO
Imports System.Text




Public Class MainPage

    'Initialise:
    Private password As String = ""

    'Data:
    Public patients As New List(Of Patient)

    'Contols (user labels-icons):
    Public Labels As New List(Of LinkLabel)
    Public Icons As New List(Of PictureBox)

    'control variables (user labels-icons):
    Private columns As New List(Of Integer)
    Private columnsicons As New List(Of Integer)
    Private max As Integer = 2
    Public RowDif As Integer = 50
    Public initialRow As Integer = 150



    Sub New()




        'Pre initialize
        CreateSaveDirectory()
        GetLanguage()

        'Designer components create
        InitializeComponent()
        Me.Text = Language.Form_Name_Main(Language.Selectedlanguage)

        setLanguage()
        getPasssword()

        initializeLabelsDimentions()

        Try
            'Get patients from savefile
            patients = SaveLoad.LoadPatientsFromJson("patients.json", password)
            If patients Is Nothing Then
                patients = New List(Of Patient)
            End If

            'Instantiate labels and icons for patients
            InstantiateByName()

        Catch ex As Exception
            Application.Exit()
        End Try




    End Sub

#Region "Instanciate"


    Private Sub CreateSaveDirectory()
        Dim appDataPath As String = Path.Combine(
             Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
             "MedicalAssistant"
         )
        If Not Directory.Exists(appDataPath) Then
            Directory.CreateDirectory(appDataPath)
        End If
    End Sub

    Private Sub GetLanguage()
        Dim language1 = SaveLoad.LoadLanguageIndex("languagesetup.txt")

        If language1 = -1 Then
            Using useradd As New LanguageSelectionPage()
                useradd.ShowDialog()
                useradd.Hide()
                If useradd.selectedlanguage <> -1 Then
                    language1 = useradd.selectedlanguage
                    Language.Selectedlanguage = language1
                    SaveLoad.SaveLanguageIndex(language1, "languagesetup.txt")
                Else
                    language1 = 0
                    Application.Exit()
                End If

            End Using
        Else
            Language.Selectedlanguage = language1
        End If
    End Sub

    Private Sub setLanguage()
        Label1.Text = Language.Search_Translation(Language.Selectedlanguage)
        Label2.Text = Language.Add_Patient_Translation(Language.Selectedlanguage)
    End Sub

    Private Sub getPasssword()
        Dim userInput As String
        userInput = InputBox(Language.message1_Translations(Language.Selectedlanguage), Language.Input_Req(Language.Selectedlanguage))
        password = userInput
    End Sub

    Private Sub initializeLabelsDimentions()
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width

        If screenWidth > 1800 Then
            max = 4
        ElseIf screenWidth > 1400 Then
            max = 3
        ElseIf screenWidth > 1000 Then
            max = 2

        End If
        For i As Integer = 0 To 4
            columns.Add(50 + i * 400)
            columnsicons.Add(20 + i * 400)
        Next

    End Sub


#End Region

#Region "Search_By_Patient_Name"
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        InstantiateByName(TextBox1.Text)
    End Sub

    Private Sub BTN_Search_Click(sender As Object, e As EventArgs) Handles BTN_Search.Click
        InstantiateByName(TextBox1.Text)
    End Sub
#End Region

#Region "Generate front end Patients"

    Private Sub InstantiateByName(Optional input As String = "")
        removeComponents()

        Dim columnnumber As Integer = 0
        Dim rownumber As Integer = 0
        Dim iteration As Integer = 1
        Dim searchpatiends As New List(Of Patient)

        'get any patients that match the input string
        For Each patient In patients
            If patient.Name.Contains(input) Or patient.SurName.Contains(input) Then
                searchpatiends.Add(patient)
            Else
                If input.Contains(" ") Then
                    Dim searchthing As String = input.Split(" ")(0)
                    Dim searchthing2 As String = input.Split(" ")(1)
                    If (searchthing = patient.Name Or searchthing = patient.SurName) Then
                        If (searchthing2 IsNot Nothing And searchthing2 <> "") Then
                            If searchthing2.Contains(patient.Name) Or searchthing2.Contains(patient.SurName) Then
                                searchpatiends.Add(patient)
                            End If
                        Else
                            searchpatiends.Add(patient)
                        End If

                    End If
                End If
            End If

        Next
        'Firstly add patient data for 1 label and then generate location and data for each label
        Dim patientcounter As Integer = searchpatiends.Count
        If (searchpatiends.Count > 0) Then
            LinkLabel1.Visible = True
            PictureBox1.Visible = True
            LinkLabel1.Text = searchpatiends(0).SurName & " " & searchpatiends(0).Name
            patientcounter -= 1
            columnnumber += 1
        Else
            LinkLabel1.Visible = False
            PictureBox1.Visible = False
        End If
        While patientcounter > 0
            Dim LocationxLabel As Integer = columns(columnnumber)
            Dim LocationxIcon As Integer = columnsicons(columnnumber)
            Dim LocationY As Integer = RowDif * rownumber + initialRow
            addlabel(LocationxLabel, LocationY, searchpatiends(iteration).SurName & " " & searchpatiends(iteration).Name)
            iteration += 1
            AddPictureBox(LocationxIcon, LocationY)
            patientcounter -= 1
            If columnnumber > max - 1 Then
                columnnumber = 0
                rownumber += 1
            Else
                columnnumber += 1
            End If
        End While

    End Sub
    Private Sub removeComponents()
        'Remove patient icons-labels
        If Labels.Count > 0 Then
            If Labels.Count > 1 Then
                For i As Integer = 0 To Labels.Count - 1
                    Me.Controls.Remove(Labels(i))
                    Labels(i).Dispose()
                Next
                For i As Integer = 0 To Icons.Count - 1
                    Me.Controls.Remove(Icons(i))
                    Icons(i).Dispose()
                Next
            End If
        End If
    End Sub



    Private Sub addlabel(locationX As Integer, locationY As Integer, labelstring As String)
        Dim newLinkLabel As New LinkLabel()

        newLinkLabel.LinkColor = LinkLabel1.LinkColor
        newLinkLabel.Font = LinkLabel1.Font
        newLinkLabel.Text = labelstring
        newLinkLabel.AutoSize = True
        newLinkLabel.Location = New Point(locationX, locationY)
        AddHandler newLinkLabel.LinkClicked, AddressOf PatientClicked
        Labels.Add(newLinkLabel)
        Me.Controls.Add(Labels(Labels.Count - 1))

    End Sub

    Private Sub AddPictureBox(locationX As Integer, locationY As Integer)
        Dim newPictureBox As New PictureBox()
        newPictureBox.BackgroundImage = PictureBox1.BackgroundImage
        newPictureBox.Size = PictureBox1.Size
        newPictureBox.BackgroundImageLayout = PictureBox1.BackgroundImageLayout
        newPictureBox.SizeMode = PictureBox1.SizeMode
        newPictureBox.Location = New Point(locationX, locationY)

        Icons.Add(newPictureBox)
        Me.Controls.Add(Icons(Icons.Count - 1))
    End Sub
#End Region

#Region "Patient Label Click"
    Private Sub PatientClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Name As String = DirectCast(sender, LinkLabel).Text
        ' You can also call another function here
        OpenPatient(Name)
    End Sub

    Private Sub OpenPatient(name As String)
        Dim INsurname As String = name.Split(" ")(0)
        Dim INname As String = name.Split(" ")(1)

        For i As Integer = 0 To patients.Count - 1
            If patients.Count > i Then
                If patients(i).SurName = INsurname And patients(i).Name = INname Then

                    Dim useradd As New PatientPage(patients, i, password)

                    useradd.ShowDialog()
                    patients = useradd.patients
                    If (useradd.madechanges) Then
                        SaveLoad.SavePatientsToJson("patients.json", patients, password)
                        MessageBox.Show("Αποθηκεύτηκαν οι αλλαγές.")
                        InstantiateByName()
                    End If
                End If
            End If



        Next


    End Sub
#End Region

#Region "Add_new_patient"
    Private Sub Add_new_patient(sender As Object, e As EventArgs) Handles BTN_Add.Click, Label2.Click
        Dim madechanges As Boolean = False
        Using useradd As New PatientPage(patients, -1, password)
            useradd.ShowDialog()
            useradd.Hide()
            madechanges = useradd.madechanges
            patients = useradd.patients

        End Using


        If (madechanges) Then
            SaveLoad.SavePatientsToJson("patients.json", patients, password)
            MessageBox.Show("Patient saved.")
            InstantiateByName()
        End If
    End Sub

#End Region

End Class

#Region "Memory Classes"

Public Class Patient
    Public Property Name As String
    Public Property SurName As String
    Public Property birthdate As Date
    Public Property Amka As String
    Public Property PhoneNumber As String
    Public Property Visitations As List(Of Patient_Visitation)

    Sub New()
        Visitations = New List(Of Patient_Visitation)()
    End Sub
    Sub New(Name As String, SurName As String, birthdate As Date, Amka As String, PhoneNumber As String)
        Visitations = New List(Of Patient_Visitation)
        Me.SurName = SurName
        Me.Name = Name
        Me.birthdate = birthdate
        Me.Amka = Amka
        Me.PhoneNumber = PhoneNumber
    End Sub
End Class
Public Class Patient_Visitation
    Public Property VisitationDate As Date
    Public Property Diagn_poreia As String
    Public Property farmakeutikhagwgh As String
    Sub New()

    End Sub
    Sub New(VisitationDate As Date, Diagn_poreia As String, farmakeutikhagwgh As String)
        Me.VisitationDate = VisitationDate
        Me.Diagn_poreia = Diagn_poreia
        Me.farmakeutikhagwgh = farmakeutikhagwgh
    End Sub
End Class

#End Region


