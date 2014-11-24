using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingTeamJudge.Models
{
    public class CompetitionModel
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string name { get; set; }
        public List<TeamModel> teams { get; set; }
        public List<ProblemModel> problems { get; set; }

        public CompetitionModel(DateTime startDate, DateTime endDate, string name)
        {
            // TODO: Complete member initialization
            this.startDate = startDate;
            this.endDate = endDate;
            this.name = name;
        }

        public CompetitionModel(DateTime startDate, DateTime endDate, string name, List<TeamModel> teams, List<ProblemModel> problems)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.name = name;
            this.teams = teams;
            this.problems = problems;
        }
    }
}