using FinalTest.View.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Controll
{
    class ControllClient
    {
        internal static List<ViewClient> GetClient()
        {
            try
            {
                DB.TsaplinEntities tsaplinEntities = new DB.TsaplinEntities();
                var client = tsaplinEntities.Client.ToList();
                List<View.ModelView.ViewClient> clients = new List<View.ModelView.ViewClient>();
                foreach (var item in client)
                {
                    clients.Add(new View.ModelView.ViewClient(item));
                }
                return clients;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }
    }
}
