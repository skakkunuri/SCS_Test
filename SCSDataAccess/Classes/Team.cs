using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SCSDataAccess
{
    /// <summary>
    /// This class is used to get the data for a team and it's related agencies 
    /// </summary>
    public class TeamAgency
    {
        public int TeamID { set; get; }
        public string Team_Desc { set; get; }
        IEnumerable<AgencyTeam> Agencies { set; get; }
    }// TeamAgency

    /// <summary>
    /// This class is only used by TeamAgency class
    /// </summary>
    public class AgencyTeam
    {
        public string Agency_Code { get; set; }
        public string Agency_Name { get; set; }
        public string Active_Ind { get; set; }
    } //AgencyTeam
    
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
            Team oneTeam;
            List<Team> teamList = new List<Team>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllTeams",con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        DataSet ds = new DataSet();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "GetAllTeams";
                        adapter.SelectCommand = cmd;
                        con.Open();
                        adapter.Fill(ds);
                        con.Close();
                        if(ds.Tables.Count > 0)
                        {
                            ds.Tables[0].TableName = "Teams";
                            foreach (DataRow row in ds.Tables["Teams"].Rows)
                            {
                                oneTeam = new Team();
                                oneTeam.Team_ID = int.Parse(row[0].ToString());
                                oneTeam.Team_Desc = row[1].ToString();
                                oneTeam.Active_Ind = row[2].ToString();
                                teamList.Add(oneTeam);
                            } //row
                        } //if 
                    } // adapter
                } // command
            } // connection
            // Also add NONE as one of the options to choose
            oneTeam = new Team();
            oneTeam.Team_ID = 0;
            oneTeam.Team_Desc = "NONE";
            oneTeam.Active_Ind = "A";
            teamList.Add(oneTeam);
            return teamList;
        }

        /// <summary>
        /// This method calls GetAllAgenciesByTeam stored procedure to fetch required data
        /// </summary>
        /// <param name="teamID"></param>
        /// <returns></returns>
        public TeamAgency GetAgenciesByTeamID(int teamID)
        {
            TeamAgency teamsAgencies = null;
            AgencyTeam oneAgencyTeam = null;
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter adpter = new SqlDataAdapter())
                    {
                        cmd.Connection = con;                        
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "GetAllAgenciesByTeam";
                        adpter.SelectCommand = cmd;
                        SqlParameter paramTeamID = new SqlParameter();
                        paramTeamID.SqlDbType = SqlDbType.Int;
                        paramTeamID.Value = teamID;
                        paramTeamID.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(paramTeamID);
                        DataSet ds = new DataSet();
                        con.Open();
                        adpter.Fill(ds);
                        con.Close();

                        if(ds.Tables.Count > 0 )
                        {
                            ds.Tables[0].TableName = "TeamTable";
                            ds.Tables[1].TableName = "TeamAgenciesTable";
                            teamsAgencies = new TeamAgency();
                            teamsAgencies.TeamID = teamID;
                            if(ds.Tables["TeamTable"].Rows.Count > 0)
                                teamsAgencies.Team_Desc = ds.Tables["TeamTable"].Rows[0].ToString();
                            if (ds.Tables["TeamAgenciesTable"].Rows.Count > 0)
                            {
                                foreach(DataRow row in ds.Tables["TeamAgenciesTable"].Rows)
                                {
                                    oneAgencyTeam = new AgencyTeam();
                                    oneAgencyTeam.Agency_Code = row[0].ToString();
                                    oneAgencyTeam.Agency_Name = row[1].ToString();
                                    oneAgencyTeam.Active_Ind = row[2].ToString();                                    
                                } // foreach
                            } // if second table
                        } // if ds
                        

                            

                    } // adapter 
                } // Command
            } // connection
                return teamsAgencies;
        }

        #endregion
    } // Team
}
