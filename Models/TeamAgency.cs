using System.Collections.Generic;

namespace SCSClient.Models
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

}