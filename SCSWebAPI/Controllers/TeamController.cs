﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
namespace SCSWebAPI.Controllers
{
    public class TeamController : ApiController
    {
        IEnumerable<SCSDataAccess.Team> activeTeams;
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
        public IEnumerable<SCSDataAccess.Team> GetActiveTeams()
        {
            SCSDataAccess.Team team = new SCSDataAccess.Team();
            activeTeams = team.GetAllTeamsData();
            return activeTeams;
        }

        /// <summary>
        /// Gets the all agencies by team id
        /// </summary>
        /// <param name="teamID"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetAgneciesByTeam")]
        public IEnumerable<SCSDataAccess.Team> GetAgenciesByTeamID(int teamID)
        {
            SCSDataAccess.Team team = new SCSDataAccess.Team();
            //activeTeams = team.GetAgenciesByTeamID(teamID);
            return activeTeams;
        }

    }
}
