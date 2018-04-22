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
            CreateStaff();
            ReadStaff();
            UpdateStaff();
            DeleteStaff();
            //Create Ward data
            CreateWard();
            CreateIsIn();
            ReadIsIn();

            //create patients
            CreatePatient();

            //create inpatients
            CreateInPatient();
        
            ReadInPatient();
            Console.Read();
        }

        static void CreateInPatient()
        {
            InPatient inPatient = new InPatient();
            inPatient.ActualDateLeft = new DateTime(2001, 10, 10);
            inPatient.DatePlacedOnWaitingList = new DateTime(2000, 09, 09);
            inPatient.ExpectedDurationOfStay = 10;
            inPatient.InWardOrWaitingList = "Ward";
            inPatient.DateExpectedToLeave = new DateTime(2001, 10, 10);
            
            inPatient.PatientNumber = 4;
            inPatient.WardNumber = 4;
            InPatientsController ipc = new InPatientsController();
            SqlException ipcer = ipc.Create(inPatient);
        }

        static void ReadInPatient()
        {
            InPatientsController ipc = new InPatientsController();
            SqlException ipcer = ipc.Read(4);

        }

        static void CreatePatient()
        {
            for (int i = 1; i < 10; i++)
            {
                Patient patient = new Patient();
                patient.Address = "patientvej 9"+i;
                patient.DateOfBirth = new DateTime(2000, i, 10);
                patient.FirstName = "hamun" +i;
                patient.Gender = "male";
                patient.LastName = "thepatient";
                patient.MartialStatus = "single";
                patient.PatientNumber = i;
                patient.Telephone = "+5412056"+i;

                PatientController pc = new PatientController();
                SqlException pcer = pc.Create(patient);
            }
        }


        static void ReadPatient()
        {

        }
        static void DeletePatient()
        {

        }
        static void UpdatePatient()
        {

        }

        static void CreateIsIn()
        {
            IsIn isin = new IsIn();
            isin.Shift = "morn";
            isin.StaffNumber = 3;
            isin.WardNumber = 3;

            IsInController iic = new IsInController();
            SqlException iccer = iic.Create(isin);
        }
        
        static void ReadIsIn()
        {
            IsInController iic = new IsInController();
            SqlException iccer = iic.Read();
        }

        static void CreateWard()
        {
            for (int i = 1; i < 10; i++)
            {
                Ward ward = new Ward();
                ward.Location = "ward " + i;
                ward.TelephoneExtentionNumber = "+1"+i;
                ward.WardNumber = i;
                ward.WardName = "medical";

                WardController wc = new WardController();
                SqlException wcse = wc.Create(ward);

            }


        }
        static void DeleteWard()
        {

        }

        static void UpdateWard()
        {

        }

        static void ReadWard()
        {

        }


        static void DeleteStaff()
        {
            StaffController sc = new StaffController();
            int id = 1;
            SqlException err = sc.Delete(id);

        }

        static void ReadStaff()
        {
            StaffController sc = new StaffController();
            sc.Read();

        }

        static void UpdateStaff()
        {
            Staff staff = new Staff();
            staff.CurrentPosition = "Chiefasdfasdf";
            staff.AppointmentNumber = 1;
            staff.CurrentSalary = 2.2;
            staff.DateOfBirth = new DateTime(1999, 09, 12);
            staff.FirstName = "John";
            staff.FullAddress = "den nye vej 9";
            staff.Gender = "male";
            staff.InsuranceNumber = 1;
            staff.LastName = "Doee";
            staff.NumberOfHoursPerWeek = 1;
            staff.PermenentOrTemporary = "temp";
            staff.QualificationID = 1;
            staff.SalaryPayment = "week";
            staff.SalaryScale = "c";
            staff.StaffNumber = 1;
            staff.WorkExperienceID = 1;

            StaffController sc = new StaffController();
            int id = 1;
            SqlException s = sc.Update(staff, id);


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
