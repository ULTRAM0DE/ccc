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
                DB.TsaplinEntities tsaplinEntities = new DB.TsaplinEntities();
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
    }
}
