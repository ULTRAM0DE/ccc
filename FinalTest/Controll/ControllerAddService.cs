using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Controll
{
    class ControllerAddService
    {
        internal static bool AddService(string name, string price, string sale, string time)
        {
            DB.Service service = new DB.Service();
            try
            {
                service.Name = name;
                service.Price = Convert.ToInt32(price);
                service.Sale = Convert.ToInt32(sale);
                service.Time = Convert.ToInt32(time);
            }
            catch
            {
                throw new Exception("Ошибка");
            }
            if(service == null)
            {
                return false;
            }
            try
            {
                DB.TsaplinEntities1 entities = new DB.TsaplinEntities1();
                entities.Service.Add(service);
                entities.SaveChanges();
                return true;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }
    }
}
