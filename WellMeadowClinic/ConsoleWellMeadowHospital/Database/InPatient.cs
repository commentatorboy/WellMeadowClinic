using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class InPatient
    {
        int patientNumber;
        int wardNumber;
        DateTime datePlacedOnWaitingList;
        int expectedDurationOfStay;
        DateTime actualDateLeft;
        string inWardOrWaitingList;
        DateTime dateExpectedToLeave;

        public int PatientNumber { get; set; }
        public int WardNumber { get; set; }
        public DateTime DatePlacedOnWaitingList { get; set; }
        public int ExpectedDurationOfStay { get; set; }
        public DateTime ActualDateLeft { get; set; }
        public string InWardOrWaitingList { get; set; }
        public DateTime DateExpectedToLeave { get; set; }
    }
}
