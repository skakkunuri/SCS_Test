using System;
using System.Windows.Forms;
using System.Threading;
using SCSClient.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Formatting;

namespace SCS_Test
{
    public partial class frmTeamAgencyAssignment : Form
    {
        #region "Private veriables"
        static HttpClient webAPIClient = new HttpClient();
        #endregion


        public frmTeamAgencyAssignment()
        {
            InitializeComponent();
        }
        #region "All form events"
        /// <summary>
        /// Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initial the service
            webAPIClient.BaseAddress = new Uri("http://localhost:61583/api/");
            webAPIClient.DefaultRequestHeaders.Accept.Clear();
            webAPIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));            
            LoadData();
            //SelectedCountLabel.Text = AllCountLabel.Text = "Count: 0";
        }
        /// <summary>
        /// When close button is clicked form will be closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Will move all the rows from All to selected section.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveAllToSelectedButton_Click(object sender, EventArgs e)
        {
            if (AllActiveAgencyDataGridView.Rows.Count <= 0)
                return;

            AllActiveAgencyDataGridView.SelectAll();
            MoveRowsBetweenGridViews(AllActiveAgencyDataGridView,SelectedAgencyDataGridView);
            AllActiveAgencyDataGridView.Rows.Clear();
            MoveAllToSelectedButton.Enabled = false;
            GetGridRowCount();
        }
        /// <summary>
        /// Move selected items from Selected to All Active grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveSelectedToAllButton_Click(object sender, EventArgs e)
        {
            if (SelectedAgencyDataGridView.Rows.Count <= 0)
                return;

            SelectedAgencyDataGridView.SelectAll();
            //Now move all to the destination grid
            MoveRowsBetweenGridViews(SelectedAgencyDataGridView,AllActiveAgencyDataGridView);          
            SelectedAgencyDataGridView.Rows.Clear();
            MoveSelectedToAllButton.Enabled = false;
            GetGridRowCount();
        }
        /// <summary>
        /// Move selected item from All Active to SelectedAgencyDataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveOneToSelectedButton_Click(object sender, EventArgs e)
        {
            if (AllActiveAgencyDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No rows selected", "No rows", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MoveRowsBetweenGridViews(AllActiveAgencyDataGridView, SelectedAgencyDataGridView,true);           
        }
        /// <summary>
        /// This event filed when the row selection of All Active grid changed to make sure that we are disabling all the buttons properly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllActiveAgencyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            MoveOneToSelectedButton.Enabled = (AllActiveAgencyDataGridView.SelectedRows.Count <= 0) ? false : true;
            MoveAllToSelectedButton.Enabled = (AllActiveAgencyDataGridView.Rows.Count <= 0) ? false : true;
            GetGridRowCount();
        }
        /// <summary>
        /// This event filed when the row selection of SelectedAgencyDataGridView changed to make sure that we are disabling all the buttons properly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedAgencyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            MoveOneToAllbutton.Enabled = (SelectedAgencyDataGridView.SelectedRows.Count <= 0) ? false : true;
            MoveSelectedToAllButton.Enabled = (SelectedAgencyDataGridView.Rows.Count <= 0) ? false : true;
            GetGridRowCount();
        }
        /// <summary>
        /// Move selected item from SelectedAgencyDataGridView to All active grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveOneToAllbutton_Click(object sender, EventArgs e)
        {
            //if (AllActiveAgencyDataGridView.SelectedRows.Count <= 0)
            //{
            //    MessageBox.Show("No rows selected", "No rows", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            for (int rowIndex = 0; rowIndex <= SelectedAgencyDataGridView.SelectedRows.Count - 1; rowIndex++)
            {
                foreach (DataGridViewRow row in SelectedAgencyDataGridView.SelectedRows)
                {
                    string agencyCode = row.Cells[0].Value.ToString();
                    string agencyName = row.Cells[1].Value.ToString();
                    // add to destination grid
                    AllActiveAgencyDataGridView.Rows.Add(agencyCode, agencyName);
                    // Delete from source grid
                    SelectedAgencyDataGridView.Rows.RemoveAt(row.Index);
                }
            }// end
        }
        #endregion

        #region "Private methods"
        private void GetGridRowCount()
        {
            SelectedCountLabel.Text = "Count: " + SelectedAgencyDataGridView.Rows.Count.ToString();
            AllCountLabel.Text = "Count: " + AllActiveAgencyDataGridView.Rows.Count.ToString();
        }
        /// <summary>
        /// This will function will fetch all the active agencies information from the database 
        /// and keeps this record in the memory
        /// </summary>
        private void LoadData()
        {
            // Get this data from database only once
            GetAgencyData();
            GetAllTeamsInformation();
            GetGridRowCount();
        }
        /// <summary>
        /// 
        /// </summary>
        private void GetAllTeamsInformation()
        {
            HttpResponseMessage response = webAPIClient.GetAsync("Team/GetActiveTeams").Result;

            if (response.IsSuccessStatusCode)
            {
                List<Team> teamList = response.Content.ReadAsAsync<List<Team>>().Result;
                TeamComboBox.Items.Clear();
                foreach (Team t in teamList)                    
                {
                    TeamComboBox.Items.Add(t.Team_Desc);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void GetAgencyData()
        {
            AllActiveAgencyDataGridView.Rows.Add("ADCR", "PHD USA (NY)");
            AllActiveAgencyDataGridView.Rows.Add("AMAG", "AMER MEDIA ADVOCACY");
            AllActiveAgencyDataGridView.Rows.Add("AMAG1", "AMER MEDIA ADVOCACY1");
            AllActiveAgencyDataGridView.Rows.Add("AMAG2", "AMER MEDIA ADVOCACY2");
            AllActiveAgencyDataGridView.Rows.Add("AMAG3", "AMER MEDIA ADVOCACY3");
            AllActiveAgencyDataGridView.Rows.Add("AMAG4", "AMER MEDIA ADVOCACY4");
            AllActiveAgencyDataGridView.Rows.Add("AMAG5", "AMER MEDIA ADVOCACY5");
            AllActiveAgencyDataGridView.Rows.Add("AMAG6", "AMER MEDIA ADVOCACY6");
            AllActiveAgencyDataGridView.Rows.Add("AMAG7", "AMER MEDIA ADVOCACY7");
            AllActiveAgencyDataGridView.Rows.Add("AMAG8", "AMER MEDIA ADVOCACY8");
            AllActiveAgencyDataGridView.Rows.Add("AMAG9", "AMER MEDIA ADVOCACY9");
            AllActiveAgencyDataGridView.Rows.Add("AMAG10", "AMER MEDIA ADVOCACY10");
            AllActiveAgencyDataGridView.Rows.Add("AMAG11", "AMER MEDIA ADVOCACY11");
            AllActiveAgencyDataGridView.Rows.Add("AMAG12", "AMER MEDIA ADVOCACY12");
            AllActiveAgencyDataGridView.Rows.Add("AMAG13", "AMER MEDIA ADVOCACY13");
            AllActiveAgencyDataGridView.Rows.Add("AMAG14", "AMER MEDIA ADVOCACY14");
            AllActiveAgencyDataGridView.Rows.Add("AMAG15", "AMER MEDIA ADVOCACY15");
        }

        private void MoveRowsBetweenGridViews(DataGridView sourceGridView, DataGridView destinationGridView, bool isMove = false)
        {
            if (sourceGridView.SelectedRows.Count <= 0)
                return;// do not do any thing
            foreach (DataGridViewRow row in sourceGridView.SelectedRows)               
            {
                string agencyCode = row.Cells[0].Value.ToString();
                string agencyName = row.Cells[1].Value.ToString();
                destinationGridView.Rows.Add(agencyCode, agencyName);
                if (isMove)
                    sourceGridView.Rows.RemoveAt(row.Index);
            }//end for
        }
        private void LoadDataForSelectedTeam(string teamCode)
        {
            //Call the service to fetch the data already exists for the selected team.
            Thread.Sleep(5000);
        }
        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            StatusLabel.Text = "Working...Please wait...";
            Refresh();
            SelectedAgencyNameLabel.Text = (TeamComboBox.Text.Equals("NONE")) ?
                "Agencies not assigned to any team" : string.Format("Selected agencies for {0} team", TeamComboBox.Text);
            LoadDataForSelectedTeam(TeamComboBox.Text.ToString());            
            StatusLabel.Text = "Ready";
            this.Cursor = Cursors.Default;
        }
        #endregion

    }
}
