using COP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonVisualComponents;

namespace COP
{
    public partial class Form1 : Form
    {
        private Person[] persons = {
            new Person("Oleg", 20, "bla", 15000, "xxxx", "yyyy"),
            new Person("Alex", 25, "bla", 25000, "xxxx", "yyyy"),
            new Person("Danil", 29, "bla", 55500, "xxxx", "yyyy")
        };

        List<String> listOfValue = new List<string> {
            "100","200","300"
        };

        User user1 = new User { userName = "Мария", userSurname = "Шестакова", age = 20 };
        User user2 = new User { userName = "Светлана", userSurname = "Завражнова", age = 20 };

        public Form1()
        {
            InitializeComponent();
            input.SetToolTip("01.01.2000");
            input.Pattern = new Regex(@"^(?:[012]?[0-9]|3[01])[.](?:0?[1-9]|1[0-2])[.](?:[0-9]{2}){1,2}");
            list1.SetVisualLayout("Студент {userSurname} {userName}, возраст {age}", '{', '}');
        }


        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            foreach (var str in listOfValue)
            {
                dropdown.AddToList(str);
            }
        }

        private void buttonCleanList_Click(object sender, EventArgs e)
        {
            dropdown.ClearList();
        }

        private void buttonTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(input.Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            list1.FillDataGrid<User>(user1);
            list1.FillDataGrid<User>(user2);
        }

        private void buttonGetDropdown_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dropdown.SelectedValue);
        }

        private void buttonSetDropdown_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxForDropdown.Text))
            {
                dropdown.SelectedValue = textBoxForDropdown.Text;
            }
        }

        private void buttonGetList_Click(object sender, EventArgs e)
        {
            MessageBox.Show(list1.GetSelectedObject<User>()?.ToString());
        }

        private void buttonGetContextExcel_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var doc = new ContextExcel();
                doc.CreateFile(fbd.SelectedPath + "/Context Report.xls", "Header example", new string[]
                {
                    "First string",
                    "Second string",
                    "Third string",
                    "Fourth string"
                }.ToList()
                );
                MessageBox.Show("Report created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonGetConfigTableExcel_Click(object sender, EventArgs e)
        {
            List<List<string>> tableHeaderList = new List<List<string>>();
            tableHeaderList.Add(new List<string>() { "First column" });
            tableHeaderList.Add(new List<string>() { "Second column", "SecCol1", "SecCol2", "SecCol3" });
            tableHeaderList.Add(new List<string>() { "Third column" });
            tableHeaderList.Add(new List<string>() { "Fourth column", "FourthCol1" });
            var columnSizes = new double?[] { null, null, null, null, 45, 30, 15 }.ToList();
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var doc = new TableExcel();
                doc.CreateFile<Person>(fbd.SelectedPath + "/Table Report.xls", "Header", tableHeaderList, persons.ToList(), columnSizes);
                MessageBox.Show("Report created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonGetLineChartExcel_Click(object sender, EventArgs e)
        {
            List<LineChartExcel.ChartSeries> chartSeriesList = new List<LineChartExcel.ChartSeries>();
            chartSeriesList.Add(new LineChartExcel.ChartSeries
            {
                Name = "First object",
                Values = new double[] { 15, 18, 19.5, 23.45, 12, 17.5 }
            });
            chartSeriesList.Add(new LineChartExcel.ChartSeries
            {
                Name = "Second object",
                Values = new double[] { 13, 16, 18.2, 21.72, 20, 25.9 }
            });
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var doc = new LineChartExcel();
                doc.CreateFile(
                    fbd.SelectedPath + "/Line Chart Report.xls",
                    "Header", "Chart header",
                    chartSeriesList,
                    LineChartExcel.LegendPosition.Bottom,
                    _xSeries: new string[] { "Pos1", "Pos2", "Pos3", "Pos4", "Pos5", "Pos6" });
                MessageBox.Show("Report created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
