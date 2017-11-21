Imports System.IO
Imports System.Security.Cryptography

Public NotInheritable Class Crypto
    Private Sub New()
    End Sub
    Public Shared ReadOnly MagicText As String = GetHash("Copyright GaSKSoft 2017")
    Shared Function EncryptStringToBytes(plainText As String, key() As Byte, iv() As Byte) As Byte()
        If plainText Is Nothing OrElse plainText.Length <= 0 Then
            Throw New ArgumentNullException("plainText")
        End If
        If key Is Nothing OrElse key.Length <= 0 Then
            Throw New ArgumentNullException("key")
        End If
        If iv Is Nothing OrElse iv.Length <= 0 Then
            Throw New ArgumentNullException("iv")
        End If
        Dim encrypted() As Byte
        Using aesAlg = Aes.Create()
            aesAlg.Key = key
            aesAlg.IV = iv
            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As New StreamWriter(csEncrypt)
                        swEncrypt.Write(plainText)
                        encrypted = msEncrypt.ToArray()
                    End Using
                End Using
            End Using
        End Using
        Return encrypted
    End Function

    Shared Function DecryptStringFromBytes(cipherText() As Byte, key() As Byte, iv() As Byte) As String
        If cipherText Is Nothing OrElse cipherText.Length <= 0 Then
            Throw New ArgumentNullException("cipherText")
        End If
        If key Is Nothing OrElse key.Length <= 0 Then
            Throw New ArgumentNullException("key")
        End If
        If iv Is Nothing OrElse iv.Length <= 0 Then
            Throw New ArgumentNullException("iv")
        End If
        Dim plaintext As String
        Using aesAlg = Aes.Create()
            aesAlg.Key = key
            aesAlg.IV = iv
            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)
            Using msDecrypt As New MemoryStream(cipherText)
                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                    Using srDecrypt As New StreamReader(csDecrypt)
                        plaintext = srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
        Return plaintext
    End Function
    Public Shared Function GetHashSalted(str As String, salt As String) As String
        salt = UCase(salt)
        Return GetHash($"{str.Reverse}{salt}{str}{salt.Reverse}")
    End Function
    Public Shared Function GetHashBytes(str As String) As Byte()
        Return New SHA1CryptoServiceProvider().ComputeHash(Text.Encoding.Unicode.GetBytes(str))
    End Function
    Public Shared Function GetHash(str As String) As String
        Return Convert.ToBase64String(GetHashBytes(str))
    End Function
    Public Shared Function GetKeyHashed(str As String) As Byte()
        Return Text.Encoding.ASCII.GetBytes(Mid(GetHash(str), 1, 16))
    End Function
End Class
