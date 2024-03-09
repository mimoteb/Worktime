Imports System.Data.Entity.Core
Imports System.Net
Imports Newtonsoft.Json.Linq

Module UpdateChecker
    Sub CheckForUpdates()
        Dim appName As String = My.Application.Info.AssemblyName
        Dim latestVersion As String = GetLatestVersionFromGitHub(appName)
        Dim currentVersion As String = My.Application.Info.Version.ToString()

        If Version.Parse(latestVersion) > Version.Parse(currentVersion) Then
            ' Update is available, implement download and installation logic
            MessageBox.Show("An update is available! Please download and install the latest version.")
        Else
            MessageBox.Show("Your application is up-to-date.")
        End If
    End Sub

    Function GetLatestVersionFromGitHub(appName As String) As String
        Dim apiUrl As String = $"https://api.github.com/repos/mimoteb/{appName}/releases/latest"
        Dim latestVersion As String = ""

        Try
            Using client As New WebClient()
                client.Headers.Add("User-Agent", "request")
                Dim jsonResult As String = client.DownloadString(apiUrl)
                Dim releaseInfo As JObject = JObject.Parse(jsonResult)
                latestVersion = releaseInfo("tag_name").ToString()
            End Using
        Catch ex As Exception
            ' Handle API request error
        End Try

        Return latestVersion
    End Function
End Module
