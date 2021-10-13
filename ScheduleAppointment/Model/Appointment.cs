using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Model
{
    public class Appointment
    {
        int uniqueId;
        Doctor doctor;
        DateTime appointmentDate;
        bool availability;
        Patient patient;

        public Appointment(int uniqueId, Doctor doctor, DateTime appointmentDate, bool availability, Patient patient)
        {
            this.UniqueId = uniqueId;
            this.Doctor = doctor;
            this.AppointmentDate = appointmentDate;
            this.availability = true;
            this.patient = null;
            this.availability = availability;
            this.patient = patient;
        }

        public int UniqueId { get => uniqueId; set => uniqueId = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
        public bool Availability { get => availability; set => availability = value; }
        public Patient Patient { get => patient; set => patient = value; }

        public string DisplayData()
        {
            return "UniqueId:" + UniqueId + ",Doctor:" + Doctor.UniqueNumber + ",AppointmentDate:" + AppointmentDate + ",Availability:" + Availability + ",Patient:" + Patient.UniqueNumber;
        }
    }
}
