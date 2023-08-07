Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text

Public Class Form1

	Private client As WebClient
	Private User As String
	Private Passw As String
	Private ftpServer As String
	Private secretFile As String = ""

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CargarCredenciales()
	End Sub

	Private Sub CargarCredenciales()
		Try
			Dim secrets As Array = File.ReadAllLines(secretFile)
			User = secrets(0)
			Passw = secrets(1)
			ftpServer = secrets(2) 'ex "ftp://c1491694.ferozo.com/public_html/"
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click
		Try
			Dim IMfile As New OpenFileDialog
			If IMfile.ShowDialog() = DialogResult.OK Then
				Dim ftpServer As String = "ftp://c1491694.ferozo.com/public_html/"

				Using httpClient As New HttpClient()
					httpClient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{User}:{Passw}")))
					Dim apiUrl As String = ftpServer + Path.GetFileName(IMfile.FileName)
					Dim fileStream As Stream = File.OpenRead(IMfile.FileName)
					Using streamContent As New StreamContent(fileStream)
						Using formData As New MultipartFormDataContent()
							formData.Add(streamContent, "file", Path.GetFileName(IMfile.FileName))
							Dim response As HttpResponseMessage = Await httpClient.PutAsync(apiUrl, formData)
							response.EnsureSuccessStatusCode()
						End Using
					End Using
				End Using
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub



End Class
