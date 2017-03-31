using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCSCommon.Models;
using SCSCommon;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SCSDataAccess
{ 
    public class Agency
    {
        #region "READONLY Variables"
        private readonly string CONNECTIONSTRING = ConfigurationManager.AppSettings.Get("ConnectionString");
        #endregion
        #region "Public properties"
        public string AgencyCode { get; set; }
        public string AgencyName { get; set; }
        public string ActiveInd { get; set; }
        public string NotAuthorizableInd { get; set; }
        public string EDIEnabledInd { get; set; }
        public string EDI_MIMInd { get; set; }
        public string BillingAgencyCode { get; set; }
        public string RequestCode { get; set; }
        public string GUID { get; set; }
        public string LegalName1 { get; set; }
        public string LegalName2 { get; set; }
        public string LegalName3 { get; set; }
        public string FwAgencyCode { get; set; }
        #endregion
        
        /// <summary>
        /// Gets all unassigned agencies - that are not assigned to any team
        /// </summary>
        /// <param name="activeIndicator"></param>
        /// <returns></returns>
        public List<AgencyTeam> GetAllUnassingedAgencies(SCSCommonConstants.TEAM_AGENCY_ACTIVE_INDICATOR activeIndicator)
        {
            List<AgencyTeam> unassingedAgencies = new List<AgencyTeam>();
            AgencyTeam oneAgenyTeam = null;
            string strActiveIndicator = "A";

            //Send correct indicator to Database
            if (activeIndicator == SCSCommonConstants.TEAM_AGENCY_ACTIVE_INDICATOR.Active)            
                strActiveIndicator = "A";            
            else if (activeIndicator == SCSCommonConstants.TEAM_AGENCY_ACTIVE_INDICATOR.Inactive)
                strActiveIndicator = "I";
            else
                strActiveIndicator = "L";

            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GetAllUnassignedAgencies";
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@CheckActive",
                        DbType = DbType.String,
                        Size = 1,
                        Value = strActiveIndicator,
                        Direction = ParameterDirection.Input
                    });
                    using (SqlDataAdapter adp = new SqlDataAdapter())
                    {
                        adp.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        con.Open();
                        adp.Fill(ds);
                        con.Close();
                        if (ds.Tables.Count > 0)
                        {
                            ds.Tables[0].TableName = "UnassignedAgencies";
                            foreach(DataRow dr in ds.Tables["UnassignedAgencies"].Rows)
                            {
                                oneAgenyTeam = new AgencyTeam()
                                {
                                    Agency_Code = dr["AGENCY_CODE"].ToString(),
                                    Agency_Name = dr["AGENCY_NAME"].ToString()
                                };
                                unassingedAgencies.Add(oneAgenyTeam);
                            } // foreach
                        }
                    } // adp
                } // cmd
            } // con
            return unassingedAgencies;
        }
    } // Agency class ending
}
