using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleWellMeadowHospital.Database;
using ConsoleWellMeadowHospital.Controllers;
using System.Data.SqlClient;

namespace ConsoleWellMeadowHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeDatabase.ConnectAndCreate();

            //Create staff data
            //CreateStaff();
            ReadStaff();

            Console.Read();
        }

        static void ReadStaff()
        {
            StaffController sc = new StaffController();
            sc.Read();

        }

        static void UpdateStaff()
        {
            StaffController sc = new StaffController();
            // LAV EN UPDATE !!!
            sc.Update();

        }

        static void CreateStaff()
        {
            for (int i = 1; i < 10; i++)
            {
                Qualification q = new Qualification();
                q.DateOfQualification = new DateTime(1995, 10, i);
                q.NameOfInstitution = "John doe instidution" + i;
                q.QualificationID = i;
                q.Type = "Teacher"+i;

                WorkExperience WE = new WorkExperience();
                WE.FinishDate = new DateTime(1999, i, 10);
                WE.NameOfOrganisation = "John doe organisation"+i;
                WE.PreviousPosition = "Head of Office"+i;
                WE.StartDate = new DateTime(1996, i, 10);
                WE.WorkExperienceID = i;

                Patient p = new Patient();
                p.Address = "John doe vej"+i;
                p.DateOfBirth = new DateTime(1994, 10, i);
                p.FirstName = "John"+i;
                p.Gender = "male";
                p.LastName = "dooe"+i;
                p.MartialStatus = "married";
                p.PatientNumber = i;
                p.Telephone = "+452342311"+i;


                PatientAppointment pa = new PatientAppointment();
                pa.AppointmentNumber = i;
                pa.AppointmentRoom = "D"+i;
                pa.DateOfAppointment = new DateTime(1991, i, 10);
                pa.PatientNumber = i;

                Staff staff = new Staff();
                staff.CurrentPosition = "Chief officer";
                staff.AppointmentNumber = i;
                staff.CurrentSalary = 2.2+i;
                staff.DateOfBirth = new DateTime(1999, i, 12);
                staff.FirstName = "John"+i;
                staff.FullAddress = "den nye vej 9" +i;
                staff.Gender = "male";
                staff.InsuranceNumber = i;
                staff.LastName = "Doee"+i;
                staff.NumberOfHoursPerWeek = i;
                staff.PermenentOrTemporary = "temp";
                staff.QualificationID = i;
                staff.SalaryPayment = "week";
                staff.SalaryScale = "c"+i;
                staff.StaffNumber = i;
                staff.WorkExperienceID = i;


                QualificationController qc = new QualificationController();
                WorkExperienceController wec = new WorkExperienceController();
                PatientController pc = new PatientController();
                PatientAppointmentController pac = new PatientAppointmentController();
                StaffController sc = new StaffController();

                SqlException qcec = qc.Create(q);
                SqlException wecec = wec.Create(WE);
                SqlException pecc = pc.Create(p);
                SqlException pacec = pac.Create(pa);
                SqlException errorCode = sc.Create(staff);
            }
        }
    }
}
