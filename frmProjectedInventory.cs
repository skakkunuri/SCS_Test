using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SCS_Test
{
    public partial class frmProjectedInventory : Form
    {
        #region "Events"
        public frmProjectedInventory()
        {
            InitializeComponent();
            ResetForm();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Dispose();
            double op = 100;
            while (op >= 10)
            {
                Opacity =  (op - 10)/100;
                Debug.WriteLine(Opacity.ToString());
                op -= 10;
                Debug.WriteLine(op.ToString());
                System.Threading.Thread.Sleep(25);
                Refresh();
                
            }
            Application.Exit();
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

        private void AdjustedQ1InventoryNumericUpDown_Enter(object sender, EventArgs e)
        {
            NumericUpDown send = (NumericUpDown)sender;
            switch (send.Name.ToString().ToUpper())
            {
                case "ADJUSTEDQ1INVENTORYNUMERICUPDOWN":
                    AdjustedQ1InventoryNumericUpDown.Select(0, AdjustedQ1InventoryNumericUpDown.Value.ToString().Length);
                    break;
                case "ADJUSTEDQ2INVENTORYNUMERICUPDOWN":
                    AdjustedQ2InventoryNumericUpDown.Select(0, AdjustedQ2InventoryNumericUpDown.Value.ToString().Length);
                    break;
                case "ADJUSTEDQ3INVENTORYNUMERICUPDOWN":
                    AdjustedQ3InventoryNumericUpDown.Select(0, AdjustedQ3InventoryNumericUpDown.Value.ToString().Length);
                    break;
                case "ADJUSTEDQ4OLDINVENTORYNUMERICUPDOWN":
                    AdjustedQ4OldInventoryNumericUpDown.Select(0, AdjustedQ4OldInventoryNumericUpDown.Value.ToString().Length);
                    break;
                case "ADJUSTEDQ4NEWINVENTORYNUMERICUPDOWN":
                    AdjustedQ4NewInventoryNumericUpDown.Select(0, AdjustedQ4NewInventoryNumericUpDown.Value.ToString().Length);
                    break;
                case "ADJUSTEDQ4TOTALINVENTORYNUMERICUPDOWN":
                    AdjustedQ4TotalInventoryNumericUpDown.Select(0, AdjustedQ4TotalInventoryNumericUpDown.Value.ToString().Length);
                    break;
            } // switch
        } //AdjustedQ1InventoryNumericUpDown_Enter
        #endregion
        #region "Private methods"
        private void ResetForm()
        {
            UserInfoLabel.Text = String.Format("Last Updated User:{0}\r\n Last Update Date:{1}\r\n Revision#:{2}", "KAKKS002", "09/09/17 14:22", "1");
        } //ResetForm
        #endregion        
    } //frmProjectedInventory
}
