using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingTeamJudge.Models
{
    public class ProblemModel
    {
        public string name { get; set; }

        public ProblemModel(string name)
        {
            // TODO: Complete member initialization
            this.name = name;
        }
    }
}