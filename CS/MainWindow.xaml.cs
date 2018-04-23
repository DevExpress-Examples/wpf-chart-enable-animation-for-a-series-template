
using System;
using System.Data;
using System.Windows;
// ...

namespace WpfChartSeriesTemplateBinding {
    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent();
        }
        void button1_Click (object sender, RoutedEventArgs e) {
            DataTable dt = new DataTable("MyDataTable");

            dt.Columns.Add("Series", typeof(string));
            dt.Columns.Add("Argument", typeof(DateTime));
            dt.Columns.Add("Value", typeof(double));

            dt.Rows.Add(new object[] { "A", DateTime.Today, 103 });
            dt.Rows.Add(new object[] { "B", DateTime.Today, 200 });
            dt.Rows.Add(new object[] { "C", DateTime.Today, 446 });
            dt.Rows.Add(new object[] { "A", DateTime.Today.AddDays(1), 788 });
            dt.Rows.Add(new object[] { "B", DateTime.Today.AddDays(1), 787 });
            dt.Rows.Add(new object[] { "C", DateTime.Today.AddDays(1), 452 });
            dt.Rows.Add(new object[] { "A", DateTime.Today.AddDays(2), 152 });
            dt.Rows.Add(new object[] { "B", DateTime.Today.AddDays(2), 565 });
            dt.Rows.Add(new object[] { "C", DateTime.Today.AddDays(2), 612 });

            chartControl1.DataSource = dt;
        }
    }
}
