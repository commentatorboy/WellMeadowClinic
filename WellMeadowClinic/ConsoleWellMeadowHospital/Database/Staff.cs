using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class Staff
    {
        int staffNumber;
        string firstName;
        string lastName;
        string fullAddress;
        DateTime dateOfBirth;
        string gender;
        int insuranceNumber;
        string currentPosition;
        double currentSalary;
        string salaryScale;
        int numberOfHoursPerWeek;
        string permanentOrTemporary;
        string salaryPayment; //monthly or weekly
        int appointmentNumber;
        int workExperience;
        int qualificationID;

        public int StaffNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int InsuranceNumber { get; set; }
        public string CurrentPosition { get; set; }
        public double CurrentSalary { get; set; }
        public string SalaryScale { get; set; }
        public int NumberOfHoursPerWeek { get; set; }
        public string PermenentOrTemporary { get; set; }
        public string SalaryPayment { get; set; }
        public int AppointmentNumber { get; set; }
        public int WorkExperience { get; set; }
        public int QualificationID { get; set; }



    }
}
