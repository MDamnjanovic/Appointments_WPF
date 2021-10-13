using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Model
{
    public class Patient : User
    {
        List<Appointment> appointments = new List<Appointment>();
        List<Therapy> therapies = new List<Therapy>();

        public Patient (string firstName, string lastName, string uniqueNumber,
            string emailAddress, string address, string sex, string password)
            : base(firstName, lastName, uniqueNumber, emailAddress, address, sex, password)
        {
        }

        public Patient(Patient patient):base(patient)
        {
           
        }

    }
}
