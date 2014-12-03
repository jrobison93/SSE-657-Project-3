using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingTeamJudgeTests
{
    class Tests
    {
        public static void Main() 
        {
            Console.WriteLine("Admin Tests:");
            Console.Write("\tTest 1: ");
            AdminTests.testCreateProblem("Test");

            Console.Write("\tTest 2: ");
            AdminTests.testCreateTeams("teamA");

            Console.Write("\tTest 3: ");
            AdminTests.testLanguageCreation("Python", ".py");

            Console.Write("\tTest 4: ");
            AdminTests.testCreateCompetition(new DateTime(2014, 12, 1, 20, 0, 0), new DateTime(2014, 12, 1, 17, 30, 0), "Test Competition");

            Console.Write("\tTest 5: ");
            AdminTests.testAddTeamAndProblem(new ProgrammingTeamJudge.Models.CompetitionModel(new DateTime(2014, 12, 1, 20, 0, 0),
                new DateTime(2014, 12, 1, 17, 30, 0), "Test"),
                new List<ProgrammingTeamJudge.Models.TeamModel>() { new ProgrammingTeamJudge.Models.TeamModel("teamA") },
                new List<ProgrammingTeamJudge.Models.ProblemModel>() { new ProgrammingTeamJudge.Models.ProblemModel("Test") });

            Console.Read();
        }
    }
}
