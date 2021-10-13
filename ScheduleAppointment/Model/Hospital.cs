using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Model
{
    public class Hospital
    {
        int id;
        string institutionName;
        Address address;

        string streetName;
        int addressNumber;
        string city;
        string country;

        public Hospital(int id, string institutionName, Address address)
        {
            this.Id = id;
            this.InstitutionName = institutionName;
            this.address = address;

            this.streetName = address.StreetName;
            this.addressNumber = address.AddressNumber;
            this.city = address.City;
            this.country = address.Country;
        }

        public int Id { get => id; set => id = value; }
        public string InstitutionName { get => institutionName; set => institutionName = value; }

        public string StreetName { get => streetName; set => streetName = value; }
        public int AddressNumber { get => addressNumber; set => addressNumber = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }


        public void setAddress(Address address)
        {
            this.address = address;
        }
        public Address getAddress()
        {
            return this.address;
        }

    }
}
