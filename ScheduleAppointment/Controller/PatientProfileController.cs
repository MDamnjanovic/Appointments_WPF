using ScheduleAppointment.Model;
using ScheduleAppointment.Repository;
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
    class PatientProfileController
    {

        public static void setPatientInfo(Patient patient, Doctor doctor, Label lbPatientInfo, Label lbDoctorInfo)
        {
            lbPatientInfo.Content = "Patient, First name : " + patient.FirstName + " Last name : " + patient.LastName;
            lbDoctorInfo.Content = "Doctor, Unique number: " + doctor.UniqueNumber + " First name : " + doctor.FirstName + " Last name : " + doctor.LastName;

        }

        public static void setAppointmentPreview (DateTime date, Doctor doctor, 
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
                tb.Background = Brushes.Red;
                btn.Visibility = Visibility.Hidden;
            }
            else
            {
                tb.Background = Brushes.Green;
                btn.Visibility = Visibility.Visible;
            }
        }



        public static void addAppointment(string time, DatePicker dtDate, Doctor doctor, Patient patient)
        {
            AppointmentRepository appointmentsRep = new AppointmentRepository();
            List<Appointment> allAppointments = appointmentsRep.getAll();



            int uniqueId = 0;
            if (allAppointments.Count > 0)
            {
                Appointment maxIdApp = allAppointments.OrderByDescending(a => a.UniqueId).FirstOrDefault();
                uniqueId = maxIdApp.UniqueId + 1;
                //MessageBox.Show("MAXID:" + maxId.ToString());
            }else
            
              uniqueId++;

            DateTime dateTimeApp = dtDate.SelectedDate.Value;
            TimeSpan ts = new TimeSpan(Convert.ToInt32(time), 0, 0);  //hh mm ss
            dateTimeApp = dateTimeApp.Date + ts;


            MessageBox.Show("uniqueId:" + uniqueId);

            Appointment newAppointment = new Appointment(uniqueId, doctor, dateTimeApp, false, patient);
            appointmentsRep.add(newAppointment);


        }
    }
}
