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
    /// Interaction logic for FrmPatient.xaml
    /// </summary>
    public partial class FrmPatient : Window
    {
        Patient patient; 
        Doctor doctor;
        public FrmPatient(Patient patient, Doctor doctor)
        {
            this.patient = patient;
            this.doctor = doctor;
            InitializeComponent();
            PatientProfileController.setPatientInfo(patient, doctor, lbPatient, lbDoctor);
            dtDate_Appointments.SelectedDate = DateTime.Now;
            PatientProfileController.setAppointmentPreview(dtDate_Appointments.SelectedDate.Value, doctor, 
                                                            tb_9AM, tb_10AM, tb_11AM, tb_12AM, tb_1PM, tb_2PM, tb_3PM, tb_4PM,
                                                            btn_9AM,  btn_10AM,  btn_11AM,  btn_12AM,  btn_1PM,  btn_2PM,  btn_3PM,  btn_4PM);
        }

        private void dtDate_Appointments_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(dtDate_Appointments.SelectedDate.ToString());
        }

        private void btn_9AM_Click(object sender, RoutedEventArgs e)
        {
            PatientProfileController.addAppointment("9", dtDate_Appointments, doctor, patient);
        }

        private void btn_10AM_Click(object sender, RoutedEventArgs e)
        {
            PatientProfileController.addAppointment("10", dtDate_Appointments, doctor, patient);
        }

        private void btn_11AM_Click(object sender, RoutedEventArgs e)
        {
            PatientProfileController.addAppointment("11", dtDate_Appointments, doctor, patient);
        }

        private void btn_12AM_Click(object sender, RoutedEventArgs e)
        {
            PatientProfileController.addAppointment("12", dtDate_Appointments, doctor, patient);
        }

        private void btn_1PM_Click(object sender, RoutedEventArgs e)
        {
            PatientProfileController.addAppointment("1", dtDate_Appointments, doctor, patient);
        }

        private void btn_2PM_Click(object sender, RoutedEventArgs e)
        {
            PatientProfileController.addAppointment("2", dtDate_Appointments, doctor, patient);
        }

        private void btn_3PM_Click(object sender, RoutedEventArgs e)
        {
            PatientProfileController.addAppointment("3", dtDate_Appointments, doctor, patient);
        }

        private void btn_4PM_Click(object sender, RoutedEventArgs e)
        {
            PatientProfileController.addAppointment("4", dtDate_Appointments, doctor, patient);
        }

        private void dtDate_Appointments_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(dtDate_Appointments.SelectedDate.ToString());
        }

        private void dtDate_Appointments_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            PatientProfileController.setAppointmentPreview(dtDate_Appointments.SelectedDate.Value, doctor,
                                                            tb_9AM, tb_10AM, tb_11AM, tb_12AM, tb_1PM, tb_2PM, tb_3PM, tb_4PM,
                                                            btn_9AM, btn_10AM, btn_11AM, btn_12AM, btn_1PM, btn_2PM, btn_3PM, btn_4PM);
        }

        private void btnShowTherapyHistory_Click(object sender, RoutedEventArgs e)
        {
            TherapyHistoryController.showTherapyHistory(patient);
        }
    }
}
