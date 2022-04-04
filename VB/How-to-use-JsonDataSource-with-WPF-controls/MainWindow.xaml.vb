Imports DevExpress.DataAccess.Json
Imports DevExpress.Xpf.Core
Imports System
Imports System.Windows.Controls

Namespace How_to_use_JsonDataSource_with_WPF_controls

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            Dim jsonDataSource = New JsonDataSource()
            Dim fileUri As Uri = New Uri("json_data.json", UriKind.RelativeOrAbsolute)
            jsonDataSource.JsonSource = New UriJsonSource(fileUri)
            jsonDataSource.Fill()
            Me.grid.ItemsSource = jsonDataSource
        End Sub
    End Class
End Namespace
