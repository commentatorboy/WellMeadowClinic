using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class Qualification
    {
        int qualificationID;
        string nameOfInstitution;
        DateTime dateOfQualification;
        string type;

        public int QualificationID { get; set; }
        public string NameOfInstitution { get; set; }
        public DateTime DateOfQualification { get; set; }
        public string Type { get; set; }
    }
}
