using System;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

using System.IO;
using OfficeOpenXml;

namespace Task_Management
{
    public partial class Analytics_Dashboard : Form
    {
        private Label lblTotalTimeSpent;
        private Label lblTaskCompletionRate;
        private Label lblUnfinishedTasks;
        private Label lblAvgTimePerTask;
        private Label lblTopTimeConsumingTasks;
        private Label lblTrends;
        private Label lblUserProductivity;
        private Label lblErrorRate;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private ComboBox cmbFilters;
        private TextBox txtSearch;
        private Button btnApplyFilters;

        public Analytics_Dashboard()
        {
            InitializeComponent();
            InitializeMetricsLabels();
            InitializeChart();
            InitializeFilters();
        }

        private void InitializeMetricsLabels()
        {
            lblTotalTimeSpent = new Label
            {
                Text = "Total Time Spent: 0 hrs",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 20)
            };

            lblTaskCompletionRate = new Label
            {
                Text = "Task Completion Rate: 0%",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 50)
            };

            lblUnfinishedTasks = new Label
            {
                Text = "Unfinished Tasks: 0",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 80)
            };

            lblAvgTimePerTask = new Label
            {
                Text = "Average Time Per Task: 0 hrs",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 110)
            };

            lblTopTimeConsumingTasks = new Label
            {
                Text = "Top Time-Consuming Tasks: None",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 140)
            };

            lblTrends = new Label
            {
                Text = "Trends: Not Available",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 170)
            };

            lblUserProductivity = new Label
            {
                Text = "User Productivity: Not Available",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 200)
            };

            lblErrorRate = new Label
            {
                Text = "Error Rate: 0%",
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 230)
            };

            this.pnl_Main.Controls.Add(lblTotalTimeSpent);
            this.pnl_Main.Controls.Add(lblTaskCompletionRate);
            this.pnl_Main.Controls.Add(lblUnfinishedTasks);
            this.pnl_Main.Controls.Add(lblAvgTimePerTask);
            this.pnl_Main.Controls.Add(lblTopTimeConsumingTasks);
            this.pnl_Main.Controls.Add(lblTrends);
            this.pnl_Main.Controls.Add(lblUserProductivity);
            this.pnl_Main.Controls.Add(lblErrorRate);
        }

        private void InitializeChart()
        {
            cartesianChart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
                Location = new Point(250, 20),
                Size = new Size(450, 300)
            };

            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Time Spent",
                    Values = new ChartValues<double> { 5, 6, 4, 8, 5, 7 }
                }
            };

            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Days",
                Labels = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Hours",
                LabelFormatter = value => value.ToString("N")
            });

            this.pnl_Main.Controls.Add(cartesianChart);
        }

        private void InitializeFilters()
        {
            cmbFilters = new ComboBox
            {
                Location = new Point(20, 270),
                Size = new Size(150, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFilters.Items.AddRange(new[] { "All Tasks", "Completed", "Pending" });

            txtSearch = new TextBox
            {
                Location = new Point(200, 270),
                Size = new Size(150, 25),
               
            };

            btnApplyFilters = new Button
            {
                Text = "Apply Filters",
                Location = new Point(360, 270),
                Size = new Size(100, 25)
            };
            btnApplyFilters.Click += BtnApplyFilters_Click;

            this.pnl_Main.Controls.Add(cmbFilters);
            this.pnl_Main.Controls.Add(txtSearch);
            this.pnl_Main.Controls.Add(btnApplyFilters);
        }

        private void BtnApplyFilters_Click(object sender, EventArgs e)
        {
            // Handle filter and search logic here
        }

        private void ExportToExcel()
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Dashboard Data");

                worksheet.Cells[1, 1].Value = "Metric";
                worksheet.Cells[1, 2].Value = "Value";

                worksheet.Cells[2, 1].Value = "Total Time Spent";
                worksheet.Cells[2, 2].Value = lblTotalTimeSpent.Text;

                worksheet.Cells[3, 1].Value = "Task Completion Rate";
                worksheet.Cells[3, 2].Value = lblTaskCompletionRate.Text;

                worksheet.Cells[4, 1].Value = "Unfinished Tasks";
                worksheet.Cells[4, 2].Value = lblUnfinishedTasks.Text;

                worksheet.Cells[5, 1].Value = "Average Time Per Task";
                worksheet.Cells[5, 2].Value = lblAvgTimePerTask.Text;

                worksheet.Cells[6, 1].Value = "Top Time-Consuming Tasks";
                worksheet.Cells[6, 2].Value = lblTopTimeConsumingTasks.Text;

                worksheet.Cells[7, 1].Value = "Trends";
                worksheet.Cells[7, 2].Value = lblTrends.Text;

                worksheet.Cells[8, 1].Value = "User Productivity";
                worksheet.Cells[8, 2].Value = lblUserProductivity.Text;

                worksheet.Cells[9, 1].Value = "Error Rate";
                worksheet.Cells[9, 2].Value = lblErrorRate.Text;

                var filePath = "DashboardData.xlsx";
                File.WriteAllBytes(filePath, package.GetAsByteArray());
                MessageBox.Show("Data exported successfully!");
            }
        }
    }
}
