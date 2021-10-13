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
    public class TherapyHistoryController
    {
        public static void showTherapyHistory (User user)
        {
           FrmTherapyHistory therapyHistory = new FrmTherapyHistory(user);
            therapyHistory.ShowDialog();
        }
        
        public static void displayTherapies (User user, DataGrid dgTherapies)
        {
            TherapyRepository therapyRepository = new TherapyRepository();
            List<Therapy> lstAllTherapies = therapyRepository.getAll();

            if (user is Patient)
            {
                Patient patient = (Patient)user;
                List<Therapy> lstPatientTherapies = lstAllTherapies.Where(t => t.getAppointment().Patient.UniqueNumber == patient.UniqueNumber).ToList();
                dgTherapies.ItemsSource= lstPatientTherapies;
            }
            else if (user is Doctor)
            {
                Doctor doctor = (Doctor)user;
                List<Therapy> lstDoctorsTherapies = lstAllTherapies.Where(t => t.getAppointment().Doctor.UniqueNumber == doctor.UniqueNumber).ToList();
                dgTherapies.ItemsSource = lstDoctorsTherapies;
            }
        }
    }
}
