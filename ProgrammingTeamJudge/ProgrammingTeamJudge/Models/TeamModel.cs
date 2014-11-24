using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingTeamJudge.Models
{
    public class TeamModel
    {
        public string name { get; set; }

        public TeamModel(string name)
        {
            // TODO: Complete member initialization
            this.name = name;
        }
    }
}