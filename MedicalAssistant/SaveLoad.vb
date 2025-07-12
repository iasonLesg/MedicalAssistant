Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.Json

Public Class SaveLoad
    Private Shared ReadOnly salt As Byte() = Encoding.UTF8.GetBytes("FixedSaltValue123") ' In production, use a random and stored salt

    Private Directory As String = ""

#Region "SaveLoadPatient"
    Public Shared Sub SavePatientsToJson(Folderpath As String, patients As List(Of Patient), password As String)
        Dim filepath As String = getDirectory() & Folderpath
        Dim options As New JsonSerializerOptions With {
            .WriteIndented = True
        }

        Dim jsonString As String = JsonSerializer.Serialize(patients, options)

        ' Derive key and IV from password
        Dim key, iv As Byte()
        DeriveKeyAndIV(password, key, iv)

        Dim encryptedData As Byte() = EncryptStringToBytes_Aes(jsonString, key, iv)
        File.WriteAllBytes(filepath, encryptedData)
    End Sub

    Public Shared Function LoadPatientsFromJson(Folderpath As String, password As String) As List(Of Patient)
        Dim filepath As String = getDirectory() & Folderpath

        If Not File.Exists(filepath) Then
            Return New List(Of Patient)()
        End If

        ' Derive key and IV from password
        Dim key, iv As Byte()
        DeriveKeyAndIV(password, key, iv)

        Try
            Dim encryptedData As Byte() = File.ReadAllBytes(filepath)
            Dim jsonString As String = DecryptStringFromBytes_Aes(encryptedData, key, iv)
            Return JsonSerializer.Deserialize(Of List(Of Patient))(jsonString)

        Catch ex As Exception
            MsgBox("Incorrect password or corrupted data." & vbCrLf & "Application will now close.", MsgBoxStyle.Critical, "Access Denied")
            Environment.Exit(0)
            Return Nothing ' Not reached, but required by compiler
        End Try
    End Function

#End Region

#Region "SaveLoadLanguage"
    Public Shared Sub SaveLanguageIndex(index As Integer, Folderpath As String)
        Dim filepath As String = getDirectory() & Folderpath
        File.WriteAllText(filepath, index.ToString())
    End Sub


    Public Shared Function LoadLanguageIndex(Folderpath As String) As Integer
        Dim filepath As String = getDirectory() & Folderpath
        If File.Exists(filepath) Then
            Dim content As String = File.ReadAllText(filepath)
            Dim index As Integer
            If Integer.TryParse(content, index) Then
                Return index
            End If
        End If
        ' Default to English (index 0) if file not found or invalid
        Return -1
    End Function



    Private Shared Function getDirectory() As String
        Dim appDataPath As String = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "MedicalAssistant"
            )
        Return appDataPath & "\"

    End Function
#End Region

#Region "Encryption"
    Private Shared Sub DeriveKeyAndIV(password As String, ByRef key As Byte(), ByRef iv As Byte())
        Using deriveBytes As New Rfc2898DeriveBytes(password, salt, 10000)
            key = deriveBytes.GetBytes(32) ' AES-256 key
            iv = deriveBytes.GetBytes(16)  ' AES block size IV
        End Using
    End Sub

    Private Shared Function EncryptStringToBytes_Aes(plainText As String, Key As Byte(), IV As Byte()) As Byte()
        Using aesAlg As Aes = Aes.Create()
            aesAlg.Key = Key
            aesAlg.IV = IV

            Dim encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As New StreamWriter(csEncrypt)
                        swEncrypt.Write(plainText)
                    End Using
                End Using
                Return msEncrypt.ToArray()
            End Using
        End Using
    End Function

    Private Shared Function DecryptStringFromBytes_Aes(cipherText As Byte(), Key As Byte(), IV As Byte()) As String
        Using aesAlg As Aes = Aes.Create()
            aesAlg.Key = Key
            aesAlg.IV = IV

            Dim decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)
            Using msDecrypt As New MemoryStream(cipherText)
                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                    Using srDecrypt As New StreamReader(csDecrypt)
                        Return srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
    End Function



#End Region

End Class
