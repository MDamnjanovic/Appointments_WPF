using ScheduleAppointment.Model;
using ScheduleAppointment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScheduleAppointment.Controller
{
    public class TherapyController
    {
        public static void setDataDisplay (Appointment appointment, Label lbDateTime, Label lbPatientData)
        {
            lbDateTime.Content = "Date : " + appointment.AppointmentDate.Date.ToString("dd.MM.yyyy.") + " Time : " + getTimeDisplay(appointment.AppointmentDate.Hour);
            lbPatientData.Content = "Unique id : " + appointment.Patient.UniqueNumber + " First Name : " + appointment.Patient.FirstName + " Last Name : " + appointment.Patient.LastName;
        }

        static string getTimeDisplay(int hours)
        {
            if (hours >= 9 && hours <= 12)
                return hours + " AM";
            else if(hours>=1 && hours <=4)
                    return hours + " PM";

            return "";
        }

        public static void addTherapy(Appointment appointment, string therapyDesc)
        {
            TherapyRepository therapyRep = new TherapyRepository();

            List<Therapy> lstTherapy = therapyRep.getAll();
            int UniqueId = 0;
            if (lstTherapy.Count > 0)
            {
                Therapy therapyMaxId = lstTherapy.OrderByDescending(t => t.UniqueId).FirstOrDefault();
                UniqueId = therapyMaxId.UniqueId + 1;
            }
            else
            {
                UniqueId++;
            }
            Therapy therapy = new Therapy(UniqueId, therapyDesc, appointment);
            therapyRep.add(therapy);
        }
    }
}
