using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Controll
{
    class ServiceClientId
    {
        internal static List<string> GetService()
        {
            DB.TsaplinEntities1 entities = new DB.TsaplinEntities1();
            var serv = entities.Service.Select(x => x.Name).ToList();
            return serv;
        }

        internal static List<string> GetClient()
        {
            DB.TsaplinEntities1 entities = new DB.TsaplinEntities1();
            var serv = entities.Client.Select(x => x.Name).ToList();
            return serv;
        }
    }
}
