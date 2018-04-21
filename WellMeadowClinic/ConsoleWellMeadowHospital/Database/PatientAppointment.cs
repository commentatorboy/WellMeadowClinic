using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class PatientAppointment
    {
        int appointmentNumber;
        DateTime dateOfAppointment;
        string appointmentRoom;
        int patientNumber;

        public int AppointmentNumber { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public string AppointmentRoom { get; set; }
        public int PatientNumber { get; set; }

    }
}
