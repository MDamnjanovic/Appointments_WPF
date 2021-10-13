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
using System.Windows.Shapes;

namespace ScheduleAppointment.View
{
    /// <summary>
    /// Interaction logic for FrmDoctor.xaml
    /// </summary>
    public partial class FrmDoctor : Window
    {
        Doctor doctor;
        public FrmDoctor(Doctor doctor)
        {
            this.doctor = doctor;
            InitializeComponent();
            DoctorProfileController.setDoctorInfo(doctor, labelDoctor);
            dtDate_Appointments.SelectedDate = DateTime.Now;
            DoctorProfileController.setAppointmentPreview(dtDate_Appointments.SelectedDate.Value, doctor,
                                                            tb_9AM, tb_10AM, tb_11AM, tb_12AM, tb_1PM, tb_2PM, tb_3PM, tb_4PM,
                                                            btn_9AM, btn_10AM, btn_11AM, btn_12AM, btn_1PM, btn_2PM, btn_3PM, btn_4PM);
        }

        private void dtDate_Appointments_SelectedDateChanged(object sender, SelectionChangedEventArgs e) 
        {
            DoctorProfileController.setAppointmentPreview(dtDate_Appointments.SelectedDate.Value, doctor,
                                                            tb_9AM, tb_10AM, tb_11AM, tb_12AM, tb_1PM, tb_2PM, tb_3PM, tb_4PM,
                                                            btn_9AM, btn_10AM, btn_11AM, btn_12AM, btn_1PM, btn_2PM, btn_3PM, btn_4PM);
        }

        private void btn_9AM_Click(object sender, RoutedEventArgs e)
        {
            DoctorProfileController.setTherapy(dtDate_Appointments.SelectedDate.Value, 9);
        }

        private void btn_10AM_Click(object sender, RoutedEventArgs e)
        {
            DoctorProfileController.setTherapy(dtDate_Appointments.SelectedDate.Value, 10);

        }

        private void btn_11AM_Click(object sender, RoutedEventArgs e)
        {
            DoctorProfileController.setTherapy(dtDate_Appointments.SelectedDate.Value, 11);

        }

        private void btn_12AM_Click(object sender, RoutedEventArgs e)
        {
            DoctorProfileController.setTherapy(dtDate_Appointments.SelectedDate.Value, 12);

        }

        private void btn_1PM_Click(object sender, RoutedEventArgs e)
        {
            DoctorProfileController.setTherapy(dtDate_Appointments.SelectedDate.Value, 1);

        }

        private void btn_2PM_Click(object sender, RoutedEventArgs e)
        {
            DoctorProfileController.setTherapy(dtDate_Appointments.SelectedDate.Value, 2);

        }

        private void btn_3PM_Click(object sender, RoutedEventArgs e)
        {
            DoctorProfileController.setTherapy(dtDate_Appointments.SelectedDate.Value, 3);

        }

        private void btn_4PM_Click(object sender, RoutedEventArgs e)
        {
            DoctorProfileController.setTherapy(dtDate_Appointments.SelectedDate.Value, 4);

        }

        private void btnShowTherapyHistory_Click(object sender, RoutedEventArgs e)
        {
            TherapyHistoryController.showTherapyHistory(doctor);
        }
    }
}
