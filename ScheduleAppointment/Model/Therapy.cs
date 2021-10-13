using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Model
{
    public class Therapy
    {
        int uniqueId;
        string therapydesc;
        Appointment appointment;
        DateTime appointmentDate;
        string doctorName;
        string patientName;

        public Therapy(int uniqueId, string therapydesc, Appointment appointment)
        {
            this.UniqueId = uniqueId;
            this.Therapydesc = therapydesc;
            this.appointment = appointment;

            this.appointmentDate = appointment.AppointmentDate;
            this.doctorName = appointment.Doctor.FirstName + " " + appointment.Doctor.LastName;
            this.patientName = appointment.Patient.FirstName + " " + appointment.Patient.LastName;

        }

        public int UniqueId { get => uniqueId; set => uniqueId = value; }
        public string Therapydesc { get => therapydesc; set => therapydesc = value; }
        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string PatientName { get => patientName; set => patientName = value; }

        public void setAppointment(Appointment appointment)
        {
            this.appointment = appointment;
        }
        public Appointment getAppointment()
        {
            return this.appointment;
        }
    }
}
