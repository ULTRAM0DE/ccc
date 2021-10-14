using FinalTest.View.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Controll
{
    class ControllServiceClient
    {
        internal static List<ViewServiceClient> GetServiceClient()
        {
            try
            {
                DB.TsaplinEntities1 tsaplinEntities = new DB.TsaplinEntities1();
                var serviceclient = tsaplinEntities.ServiceClient.ToList();
                List<View.ModelView.ViewServiceClient> serviceClients = new List<View.ModelView.ViewServiceClient>();
                foreach (var item in serviceclient)
                {
                    serviceClients.Add(new View.ModelView.ViewServiceClient(item));
                }
                return serviceClients;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }
    }
}
