using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Model
{
    public class Doctor : User
    {
        Hospital hospital;
        List<Appointment> appointments = new List<Appointment>();

        public Doctor(string firstName, string lastName, string uniqueNumber, 
            string emailAddress, string address, string sex, string password, Hospital hospital) 
            : base (firstName, lastName, uniqueNumber, emailAddress, address, sex, password)
        {
            this.hospital = hospital;
        }

        public Doctor(User user, Hospital hospital): base(user)
        {
            this.hospital = hospital;
        }

        public void setHospital (Hospital hospital)
        {
            this.hospital = hospital;
        }
        public Hospital getHospital ()
        {
            return this.hospital;
        }


       // public Hospital Hospital { get => hospital; set => hospital = value; }
    }
}
