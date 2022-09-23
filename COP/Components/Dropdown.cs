using System;
using System.Windows.Forms;

namespace COP.Components
{
    public partial class Dropdown : UserControl
    {
        public string SelectedValue
        {
            get => comboBox.SelectedItem != null ? comboBox.SelectedItem.ToString() : string.Empty;
            set
            {
                if (comboBox.Items.Contains(value))
                {
                    comboBox.SelectedItem = value;
                }
            }
        }

        private event EventHandler _notify;
        public event EventHandler Notify
        {
            add { _notify += value; }
            remove { _notify -= value; }
        }
        private void LoadData()
        {
            comboBox.SelectedValueChanged += _notify;
        }

        public Dropdown()
        {
            InitializeComponent();
            LoadData();
        }

        public void AddToList(String str)
        {
            comboBox.Items.Add(str);
        }

        

        public void ClearList()
        {
            comboBox.Items.Clear();
            comboBox.Text = string.Empty;
        }
    }
}
