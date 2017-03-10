using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SCSDataAccess
{
    public class Team
    {
        #region "Private variables"
        SqlConnection scsConnection = new SqlConnection();
        #endregion

        #region "Public properties"
        public int Team_ID { get; set; }
        public string Team_Desc { get; set; }
        public string Active_Ind { get; set; }
        #endregion

        #region "Public methods"
        public List<Team> GetAllTeamsData()
        {
            List<Team> teamList = new List<Team>();


            return teamList;
        }
        #endregion


    }
}
