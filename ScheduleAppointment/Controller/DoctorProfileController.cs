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
using System.Windows.Media;

namespace ScheduleAppointment.Controller
{
    class DoctorProfileController
    {

        public static void setDoctorInfo (Doctor doctor, Label lbDoctorInfo)
        {
            lbDoctorInfo.Content = "Unique number: " + doctor.UniqueNumber + " First name : " + doctor.FirstName + " Last name : " + doctor.LastName;
        }

        public static void setAppointmentPreview(DateTime date, Doctor doctor,
           TextBox tb9AM, TextBox tb10AM, TextBox tb11AM, TextBox tb12AM, TextBox tb1PM, TextBox tb2PM, TextBox tb3PM, TextBox tb4PM,
           Button btn_9AM, Button btn_10AM, Button btn_11AM, Button btn_12AM, Button btn_1PM, Button btn_2PM, Button btn_3PM, Button btn_4PM)
        {
            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.getAll();

            List<Appointment> appointmentsDate = appointments.Where(a => a.AppointmentDate.Date == date.Date && a.Doctor.UniqueNumber == doctor.UniqueNumber).ToList();

            set_TextBox_Button_Appearance(tb9AM, btn_9AM, appointmentsDate, 9);
            set_TextBox_Button_Appearance(tb10AM, btn_10AM, appointmentsDate, 10);
            set_TextBox_Button_Appearance(tb11AM, btn_11AM, appointmentsDate, 11);
            set_TextBox_Button_Appearance(tb12AM, btn_12AM, appointmentsDate, 12);
            set_TextBox_Button_Appearance(tb1PM, btn_1PM, appointmentsDate, 1);
            set_TextBox_Button_Appearance(tb2PM, btn_2PM, appointmentsDate, 2);
            set_TextBox_Button_Appearance(tb3PM, btn_3PM, appointmentsDate, 3);
            set_TextBox_Button_Appearance(tb4PM, btn_4PM, appointmentsDate, 4);


        }

        public static void set_TextBox_Button_Appearance(TextBox tb, Button btn, List<Appointment> lstAppointmentsOnDate_Doctor, int time)
        {
            Appointment appointmentOnTime = lstAppointmentsOnDate_Doctor.Where(a => a.AppointmentDate.Hour == time).FirstOrDefault();
            //MessageBox.Show("appointmentOnTime: " + appointmentOnTime.AppointmentDate);
            if (appointmentOnTime != null)
            {
                tb.Text = appointmentOnTime.Patient.UniqueNumber + ") " + appointmentOnTime.Patient.FirstName + " " + appointmentOnTime.Patient.LastName; 
                //tb.Background = Brushes.Red;
                btn.Visibility = Visibility.Visible;
            }
            else
            {
                //tb.Background = Brushes.Green;
                tb.Text = "";
                btn.Visibility = Visibility.Hidden;
            }
        }

        public static void setTherapy(DateTime dtDate, int time)
        {
            AppointmentRepository appointmentRep = new AppointmentRepository();
            List<Appointment> lstAppointments = appointmentRep.getAll();
            Appointment appointmentTherapy = lstAppointments.Where(a => a.AppointmentDate.Date == dtDate.Date && a.AppointmentDate.Hour == time).FirstOrDefault();

            FrmTherapy frmTherapy = new FrmTherapy(appointmentTherapy);
            frmTherapy.ShowDialog();

        }
    }
}
