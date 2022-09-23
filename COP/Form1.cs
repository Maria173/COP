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

namespace COP
{
    public partial class Form1 : Form
    {
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
    }
}
