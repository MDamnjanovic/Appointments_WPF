using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Model
{
     public class Address
    {
        int id;
        string streetName;
        int addressNumber;
        string city;
        string country;

        public Address(int id, string streetName, int addressNumber, string city, string country)
        {
            this.Id = id;
            this.streetName = streetName;
            this.AddressNumber = addressNumber;
            this.City = city;
            this.Country = country;
        }

        public int Id { get => id; set => id = value; }
        public string StreetName { get => streetName; set => streetName = value; }
        public int AddressNumber { get => addressNumber; set => addressNumber = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
    }
}
