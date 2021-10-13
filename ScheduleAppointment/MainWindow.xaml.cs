using ScheduleAppointment.Controller;
using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScheduleAppointment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainController.initializeComboCities(cbCity);
            MainController.displayHospitals(cbCity, dgHospitals);
            MainController.setVisibility_LoggedInPatient(false, btnScheduleAppointment);
        }

        private void cbCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainController.displayHospitals(cbCity, dgHospitals);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginController.doctorLoggedIn != null || LoginController.patientLoggedIn != null)
            {
                MainController.logOut(btnLogIn);
                MainController.setVisibility_LoggedInPatient(false, btnScheduleAppointment);
              
            }
            else
            {

                //does not execute if user already logged in
                User loggedInUser = MainController.displayLoginForm();
                if (loggedInUser is Patient)
                    MainController.setVisibility_LoggedInPatient(true, btnScheduleAppointment);
                if (loggedInUser is Doctor)
                {
                    MainController.setVisibility_LoggedInPatient(true, btnScheduleAppointment);
                    btnScheduleAppointment.Content = "Set Therapy";
                }


                if (loggedInUser != null)
                {
                    btnLogIn.Content = "Log out";
                  

                }
            }

        }

        

        private void dgHospitals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Hospital selectedHospital = (Hospital)dgHospitals.SelectedItem;
            MainController.displayDoctors(selectedHospital, dgDoctors);
        }

        private void btnScheduleAppointment_Click(object sender, RoutedEventArgs e)
        {
            Doctor doctor = (Doctor)dgDoctors.SelectedItem;

            if (LoginController.patientLoggedIn != null && dgDoctors.SelectedIndex >= 0)
                MainController.displayPatient_Form(doctor);
            if (LoginController.doctorLoggedIn != null)
                MainController.displayDoctor_Form();

        }
    }
}
