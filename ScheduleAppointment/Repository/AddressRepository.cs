using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Repository
{
    class AddressRepository : IRepository<Address>
    {
        public void add(Address objectElement)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void edit(Address objectElement)
        {
            throw new NotImplementedException();
        }

        public List<Address> getAll()
        {
            throw new NotImplementedException();
        }

        public Address getOne(int id)
        {
            string[] fileLines = File.ReadAllLines("../../Data/addresses.txt");
            foreach (string line in fileLines)
            {
                int addressId = Convert.ToInt32(line.Split(',')[0]);
                if(addressId == id)
                {
                    string streetName = line.Split(',')[1];
                    int addressNumber = Convert.ToInt32(line.Split(',')[2]);
                    string cityName = line.Split(',')[3];
                    string countryName = line.Split(',')[4];

                    return new Address(addressId, streetName, addressNumber, cityName, countryName);

                }
            }
            return null;
        }

        public Address getOne(string id)
        {
            throw new NotImplementedException();
        }
    }
}
