Imports System
Imports System.Data
Imports System.Windows
' ...

Namespace WpfChartSeriesTemplateBinding
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim dt As New DataTable("MyDataTable")

            dt.Columns.Add("Series", GetType(String))
            dt.Columns.Add("Argument", GetType(Date))
            dt.Columns.Add("Value", GetType(Double))

            dt.Rows.Add(New Object() { "A", Date.Today, 103 })
            dt.Rows.Add(New Object() { "B", Date.Today, 200 })
            dt.Rows.Add(New Object() { "C", Date.Today, 446 })
            dt.Rows.Add(New Object() { "A", Date.Today.AddDays(1), 788 })
            dt.Rows.Add(New Object() { "B", Date.Today.AddDays(1), 787 })
            dt.Rows.Add(New Object() { "C", Date.Today.AddDays(1), 452 })
            dt.Rows.Add(New Object() { "A", Date.Today.AddDays(2), 152 })
            dt.Rows.Add(New Object() { "B", Date.Today.AddDays(2), 565 })
            dt.Rows.Add(New Object() { "C", Date.Today.AddDays(2), 612 })

            chartControl1.DataSource = dt
        End Sub
    End Class
End Namespace
