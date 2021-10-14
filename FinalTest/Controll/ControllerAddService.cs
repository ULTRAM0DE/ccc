using FinalTest.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        internal static bool AddChangeService(string name, string price, string sale, string time, Service service)
        {
            DB.TsaplinEntities1 entities1 = new DB.TsaplinEntities1();
            DB.Service service1 = entities1.Service.Find(service.Id);
            
            try
            {
                service = new DB.Service();
                service.Name = name;
                service.Price = Convert.ToInt32(price);
                service.Sale = Convert.ToInt32(sale);
                service.Time = Convert.ToInt32(time);
            }
            catch
            {
                throw new Exception("Ошибка");
            }
            if (service == null)
            {
                return false;
            }
            try
            {
                DB.TsaplinEntities1 entities = new DB.TsaplinEntities1();
                entities.Service.AddOrUpdate(service);
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
