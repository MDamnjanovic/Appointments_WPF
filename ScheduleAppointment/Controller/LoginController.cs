using ScheduleAppointment.Model;
using ScheduleAppointment.Repository;
using ScheduleAppointment.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScheduleAppointment.Controller
{
    public class LoginController
    {

        public static Patient patientLoggedIn=null; 
        public static Doctor doctorLoggedIn = null;
        public static void login (TextBox tbUserName, PasswordBox pbPassword)
        {
            string username = tbUserName.Text;
            string password = pbPassword.Password;

            User user = userExists(username, password);
            if (user is Doctor)
            {
                Doctor doctor = (Doctor)user;
                doctorLoggedIn = new Doctor(doctor, doctor.getHospital());
                FrmDoctor frmDoctor = new FrmDoctor(doctor);
                frmDoctor.ShowDialog();
            }
            if (user is Patient)
            {
                Patient patient = (Patient)user;
                patientLoggedIn = new Patient(patient);
                

                /*
                FrmPatient frmPatient = new FrmPatient(patient);
                frmPatient.ShowDialog();
                */
            }

        }

        public static User userExists(string userName, string password)
        {

            List<Doctor> lstDoctors = new List<Doctor>();
            List<Patient> lstPatients = new List<Patient>();
            DoctorRepository doctorsRep = new DoctorRepository();
            lstDoctors = doctorsRep.getAll();
            PatientRepository patientsRep = new PatientRepository();
            lstPatients = patientsRep.getAll();

            foreach (Doctor doctor in lstDoctors)
            {
                if (doctor.EmailAddress == userName && doctor.Password == password)
                {
                    return doctor;
                }
            }
            foreach (Patient patient in lstPatients)
            {
                if (patient.EmailAddress == userName && patient.Password == password)
                {
                    return patient;
                }
            }


            return null;
        }
    }
}
