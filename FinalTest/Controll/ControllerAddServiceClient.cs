using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Controll
{
    class ControllerAddServiceClient
    {
        internal static bool AddServiceClient(object service, object client, string date)
        {
            DB.ServiceClient serviceClient = new DB.ServiceClient();
            try
            {
                serviceClient.Service = GetServiceId(service as string);
                serviceClient.Client = GetClientId(client as string);
                serviceClient.Date = Convert.ToDateTime(date);
            }
            catch
            {
                throw new Exception("Ошибка");
            }
            if (serviceClient == null)
            {
                return false;
            }
            try
            {
                DB.TsaplinEntities1 entities = new DB.TsaplinEntities1();
                entities.ServiceClient.Add(serviceClient);
                entities.SaveChanges();
                return true;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }

        private static int GetClientId(string serviceclient)
        {
            DB.TsaplinEntities1 tsaplinEntities = new DB.TsaplinEntities1();
            return tsaplinEntities.Client.Where(x => x.Name == serviceclient).First().Id;
        }

        private static int GetServiceId(string serviceclient)
        {
            DB.TsaplinEntities1 tsaplinEntities = new DB.TsaplinEntities1();
            return tsaplinEntities.Service.Where(x => x.Name == serviceclient).First().Id;
        }
    }
}
