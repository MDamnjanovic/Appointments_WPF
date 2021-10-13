using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Repository
{
    class HospitalRepository : IRepository<Hospital>
    {
        public void add(Hospital objectElement)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void edit(Hospital objectElement)
        {
            throw new NotImplementedException();
        }

        public List<Hospital> getAll()
        {
            List<Hospital> hospitals = new List<Hospital>();
            string[] fileLines = File.ReadAllLines("../../Data/hospitals.txt");
            foreach (string line in fileLines)
            {
                int id = Convert.ToInt32(line.Split(',')[0]);
                string name = line.Split(',')[1];
                int addressId = Convert.ToInt32(line.Split(',')[2]);

                AddressRepository adrRep = new AddressRepository();
                Address address = adrRep.getOne(addressId);
                Hospital hospital = new Hospital(id, name, address);
                hospitals.Add(hospital);



            }
            return hospitals;

        }

        public Hospital getOne(int id)
        {
            List<Hospital> hospitals = getAll();
            foreach (Hospital hospital in hospitals)
            {
                if (hospital.Id == id)
                    return hospital;
            }
            return null;
        }

        public Hospital getOne(string id)
        {
            throw new NotImplementedException();
        }
    }
}
