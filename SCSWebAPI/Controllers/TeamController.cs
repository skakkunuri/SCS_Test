using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SCSWebAPI.Models;
//using SCSDataAccess;
namespace SCSWebAPI.Controllers
{
    public class TeamController : ApiController
    {
        Team[] activeTeams = new Team[]
        {
            new Team{Team_ID = 1, Team_Desc="ABCD", Active_Ind="A" },
            new Team{Team_ID = 2, Team_Desc="MNOP", Active_Ind="I" },
            new Team{Team_ID = 3, Team_Desc="WXYZ", Active_Ind="A" }
        };
        /// <summary>
        /// Get a team information absed on team id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetTeamByID")]
        public IHttpActionResult GetTeam(int teamID)
        {
            return Ok(activeTeams.FirstOrDefault(t => t.Team_ID == teamID));
        }
        /// <summary>
        /// Get all active teams from the database.
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        public IEnumerable<Team> GetActiveTeams()
        {            
            return activeTeams;
        }
       

    }
}
