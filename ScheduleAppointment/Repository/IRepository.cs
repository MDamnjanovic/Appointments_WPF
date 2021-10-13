using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Repository
{
    interface IRepository<T>
    {
        void add(T objectElement);
        void edit(T objectElement);
        void delete(int id);
        List<T> getAll();
        T getOne(int id);
        T getOne(string id);
    }
}
