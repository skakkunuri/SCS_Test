using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SCSDataAccess
{
    public class Team
    {
        #region "READONLY Variables"
        private readonly string CONNECTIONSTRING  = ConfigurationManager.AppSettings.Get("ConnectionString");
        #endregion
        #region "Private variables"
        //SqlConnection scsConnection = new SqlConnection();
        #endregion
        #region "Public properties"
        public int Team_ID { get; set; }
        public string Team_Desc { get; set; }
        public string Active_Ind { get; set; }
        #endregion
        #region "Public methods"
        public IEnumerable<Team> GetAllTeamsData()
        {
            List<Team> teamList = new List<Team>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllTeams",con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        if(ds.Tables.Count <=0)
                        {
                            ds.Tables[0].TableName = "Teams";
                            foreach (DataRow row in ds.Tables["Teams"].Rows)
                            {
                                Team oneTeam = new Team();
                                oneTeam.Team_ID = int.Parse(row[0].ToString());
                                oneTeam.Team_Desc = row[1].ToString();
                                oneTeam.Active_Ind = row[2].ToString();
                                teamList.Add(oneTeam);
                            } //row
                        } //if 
                    } // adapter
                } // command
            } // connection
            return teamList;
        }
        #endregion
    } // Team
}
