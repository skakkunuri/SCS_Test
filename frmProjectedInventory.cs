using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCS_Test
{
    public partial class frmProjectedInventory : Form
    {
        public frmProjectedInventory()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GetInventorybutton_Click(object sender, EventArgs e)
        {
            CurrentQ1InventoryNumericUpDown.Value = 242343.5M;
            CurrentQ2InventoryNumericUpDown.Value = 258523.0M;
            CurrentQ3InventoryNumericUpDown.Value = 98525413.5M;
            CurrentQ4OldInventoryNumericUpDown.Value = 8741552.5M;
            CurrentQ4NewInventoryNumericUpDown.Value = 0.5M;
            CurrentQ4TotalInventoryNumericUpDown.Value = 8741553.0M;

            AdjustedQ1InventoryNumericUpDown.Value = 234234.5M;
            AdjustedQ2InventoryNumericUpDown.Value = 85852.0M;
            AdjustedQ3InventoryNumericUpDown.Value = 55555.5M;
            AdjustedQ4OldInventoryNumericUpDown.Value = 35454.5M;
            AdjustedQ4NewInventoryNumericUpDown.Value = 0.5M;
            AdjustedQ4TotalInventoryNumericUpDown.Value = 35455.0M;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data saved successfully!!!", "Project Inventory Adjustments", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DaypartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DaypartComboBox.Text.Equals("News") || DaypartComboBox.Text.Equals("DADT"))
            {
                SubDaypartComboBox.Enabled = true;
            }
            else
            {
                SubDaypartComboBox.Enabled = false;
            }
        }
    }
}
