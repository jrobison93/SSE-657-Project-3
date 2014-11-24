using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingTeamJudge.Models
{
    public class LanguageModel
    {
        public string name { get; set; }
        public string extension { get; set; }

        public LanguageModel(string name, string extension)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.extension = extension;
        }
    }
}