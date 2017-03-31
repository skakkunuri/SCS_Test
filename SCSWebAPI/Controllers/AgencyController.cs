using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SCSCommon.Models;
using SCSDataAccess;

namespace SCSWebAPI.Controllers
{
    public class AgencyController : ApiController
    {
        [HttpGet]
        public List<AgencyTeam> GetAllUnassingedActiveAgencies()
        {
            return(GetAllUnassingedAgencies(SCSCommon.SCSCommonConstants.TEAM_AGENCY_ACTIVE_INDICATOR.Active));
            
        }// GetAllUnassingedActiveAgencies

        [HttpGet]
        public List<AgencyTeam> GetAllUnassingedInactiveAgencies()
        {
            return (GetAllUnassingedAgencies(SCSCommon.SCSCommonConstants.TEAM_AGENCY_ACTIVE_INDICATOR.Inactive));
            
        }// GetAllUnassingedInactiveAgencies

        [HttpGet]
        public List<AgencyTeam> GetAllUnassingedAllAgencies()
        {
            return(GetAllUnassingedAgencies(SCSCommon.SCSCommonConstants.TEAM_AGENCY_ACTIVE_INDICATOR.All));            
        }// GetAllUnassingedAllAgencies
        
        private List<AgencyTeam> GetAllUnassingedAgencies(SCSCommon.SCSCommonConstants.TEAM_AGENCY_ACTIVE_INDICATOR indicator)
        {
            List<AgencyTeam> result = new List<AgencyTeam>();
            Agency agency = new Agency();
            return (agency.GetAllUnassingedAgencies(indicator));            
        }// GetAllUnassingedAgencies
    }
}
