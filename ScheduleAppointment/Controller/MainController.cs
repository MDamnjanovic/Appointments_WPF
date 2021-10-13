using ScheduleAppointment.Model;
using ScheduleAppointment.Repository;
using ScheduleAppointment.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ScheduleAppointment.Controller
{
    public class MainController
    {
        static AddressRepository addressRepository = new AddressRepository();
        static HospitalRepository hospitalRepository = new HospitalRepository();

        public static void displayDoctor_Form()
        {
            FrmDoctor doctor = new FrmDoctor(LoginController.doctorLoggedIn);
            doctor.ShowDialog();
        }
        public static void displayPatient_Form(Doctor doctor)
        {
            FrmPatient newPatient = new FrmPatient(LoginController.patientLoggedIn, doctor);
            newPatient.ShowDialog();
        }

        /*
        public static void displayDoctorPatient_Form()
        {
            if (LoginController.patientLoggedIn != null)
            {
                FrmPatient newPatient = new FrmPatient(LoginController.patientLoggedIn);
                newPatient.ShowDialog();
            }
            if (LoginController.doctorLoggedIn != null)
            {
                FrmDoctor doctor = new FrmDoctor(LoginController.doctorLoggedIn);
                doctor.ShowDialog();
            }
        }
        */

        public static User displayLoginForm()
        {
           // if (LoginController.doctorLoggedIn != null && LoginController.patientLoggedIn != null)
            //{
                FrmLogIn frm = new FrmLogIn();
                frm.ShowDialog();
                if (LoginController.patientLoggedIn != null)
                    return LoginController.patientLoggedIn;
                if (LoginController.doctorLoggedIn != null)
                    return LoginController.doctorLoggedIn;

            //}

            return null;
        }

        public static void logOut(Button btnLogIn_LogOut) {

            LoginController.doctorLoggedIn = null;
            LoginController.patientLoggedIn = null;
            btnLogIn_LogOut.Content = "Log in";
        }

        public static void initializeComboCities(ComboBox cbCities) //10 00
        {
            List<Hospital> hospitals = hospitalRepository.getAll();
            List<string> cityNames = hospitals.Select(x => x.getAddress().City).Distinct().ToList();

            cbCities.Items.Add("All cities");
            foreach (string name in cityNames)
            {
                cbCities.Items.Add(name);
            }
            if (cbCities.Items.Count > 0)
                cbCities.SelectedIndex = 0;
        }

        public static void displayHospitals(ComboBox cbCity, DataGrid dgHospitals)
        {
            List<Hospital> hospitals = hospitalRepository.getAll();
            
            string cityName = cbCity.SelectedItem.ToString();
            if (cityName == "All cities")
                dgHospitals.ItemsSource = hospitals;
            else
            {
                List<Hospital> hospitalsCity = hospitals.Where(h => h.getAddress().City == cityName).ToList();
                dgHospitals.ItemsSource = hospitalsCity;
            }
        }

        public static void displayDoctors (Hospital hospital, DataGrid dgDoctors)
        {
            DoctorRepository doctorRep = new DoctorRepository();
            List<Doctor> doctors = doctorRep.getAll();
            if (hospital != null)
            {
                List<Doctor> doctorsHospital = doctors.Where(d => d.getHospital().Id == hospital.Id).ToList();
                dgDoctors.ItemsSource = doctorsHospital;
            }
            else
            {
                dgDoctors.ItemsSource = null;
                dgDoctors.Items.Refresh();
            }

        }

        public static void setVisibility_LoggedInPatient(bool loggedIn, Button btnScheduleAppointment)
        {
            if (loggedIn)
            {
                btnScheduleAppointment.Visibility = Visibility.Visible;
            }
            else
            {
                btnScheduleAppointment.Visibility = Visibility.Hidden;
            }
        }
    }
}
