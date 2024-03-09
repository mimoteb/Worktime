Imports System.Data.Entity.Core
Imports System.Net
Imports Newtonsoft.Json.Linq

Module UpdateChecker
    Dim AppName As String = My.Application.Info.AssemblyName
    Dim currentVersion As String = My.Application.Info.Version.ToString()

    Public Function GetLatestVersionFromGitHub(ByVal Developer As String, ByVal repo As String) As String
        Dim apiUrl As String = $"https://api.github.com/repos/{Developer}/{repo}/releases/latest"
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

        If Version.Parse(latestVersion) > Version.Parse(currentVersion) Then
            ' Update is available, implement download and installation logic
            MessageBox.Show("An update is available! Please download and install the latest version.")
        Else
            MessageBox.Show("Your application is up-to-date.")
        End If
        Debug.WriteLine(latestVersion)
        Return latestVersion
    End Function

End Module
