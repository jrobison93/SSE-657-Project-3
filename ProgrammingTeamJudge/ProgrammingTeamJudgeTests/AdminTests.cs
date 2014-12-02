using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammingTeamJudge.Models;

namespace ProgrammingTeamJudgeTests
{
    public class AdminTests
    {
        //
        // This test ensures that a Competition can be created from the Admin page.

        public void testCreateCompetition(DateTime startDate, DateTime endDate, string name)
        {
            CompetitionModel competition = new CompetitionModel(startDate, endDate, name);

            if(startDate == competition.startDate && endDate == competition.endDate && name == competition.name)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed:");
                Console.WriteLine("\tExpected: " + startDate + ": Actual: " + competition.startDate);
                Console.WriteLine("\tExpected: " + endDate + ": Actual: " + competition.endDate);
                Console.WriteLine("\tExpected: " + name + ": Actual: " + competition.name);
            }

        }

        //
        // This test ensures that a Team can be created from the Admin page.

        public void testCreateTeams(string name)
        {
            TeamModel team = new TeamModel(name);

            if(name == team.name)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed:");
                Console.WriteLine("\tExpected: " + name + ": Actual: " + team.name);
            }
        }

        //
        // This test ensures that a Problem can be created from the Admin page.

        public void testCreateProblem(string name)
        {
            ProblemModel problem = new ProblemModel(name);
            
            if(name == problem.name)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed:");
                Console.WriteLine("\tExpected: " + name + ": Actual: " + problem.name);
            }
        }

        // 
        // This test ensures that a Team and a Problem can be added to an existing Competition.

        public void testAddTeamAndProblem(CompetitionModel competition, List<TeamModel> teams, List<ProblemModel> problems)
        {
            competition.teams = teams;
            competition.problems = problems;

            if(teams == competition.teams && problems == competition.problems)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed:");
                Console.WriteLine("\tExpected: " + teams.Count + " teams: Actual: " + competition.teams.Count + " teams");
            }
        }

        //
        // This test ensures that Languages can be created correctly.

        public void testLanguageCreation(string name, string extension)
        {
            LanguageModel language = new LanguageModel(name, extension);

            if(name == language.name && extension == language.extension)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed: ");
                Console.WriteLine("\tExpected: " + name + ": Actual: " + language.name);
                Console.WriteLine("\tExpected: " + extension + ": Actual: " + language.extension);
            }
        }
    }
}
