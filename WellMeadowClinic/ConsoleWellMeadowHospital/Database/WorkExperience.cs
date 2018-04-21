using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class WorkExperience
    {
        int workExperienceID;
        string previousPosition;
        string nameOfOrganisation;
        DateTime startDate;
        DateTime finishDate;


        public int WorkExperienceID { get; set; }
        public string PreviousPosition { get; set; }
        public string NameOfOrganisation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
