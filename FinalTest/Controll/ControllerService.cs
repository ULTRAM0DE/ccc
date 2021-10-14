using FinalTest.View.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Controll
{
    class ControllerService
    {
        internal static List<ViewSerrvice> GetService()
        {
            try
            {
                DB.TsaplinEntities1 tsaplinEntities = new DB.TsaplinEntities1();
                var service = tsaplinEntities.Service.ToList();
                List<View.ModelView.ViewSerrvice> serrvices = new List<ViewSerrvice>();
                foreach (var item in service)
                {
                    serrvices.Add(new ViewSerrvice(item));
                }
                return serrvices;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
            
        }

       

       /* internal static void Remove(DB.Service service)
        {
            try
            {
                DB.TsaplinEntities1 entities1 = new DB.TsaplinEntities1();
                entities1.Service.Remove(entities1.Service.Find(service.Id));
                entities1.SaveChanges();
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }*/
    }
}
