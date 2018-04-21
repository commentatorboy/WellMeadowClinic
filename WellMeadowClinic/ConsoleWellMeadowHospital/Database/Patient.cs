using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class Patient
    {
        int patientNumber;
        string firstName;
        string lastName;
        string address;
        string maritalStatus;
        string gender;
        string telephone;
        DateTime dateOfBirth;


        public int PatientNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MartialStatus { get; set; }
        public string Gender { get; set; }
        public string Telephone { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
