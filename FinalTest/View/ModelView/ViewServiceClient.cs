using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.View.ModelView
{
    class ViewServiceClient
    {
        public string Service { get; set; }
        public string Client { get; set; }
        public string Date { get; set; }

        public ViewServiceClient(DB.ServiceClient service)
        {
            Service = $"{service.Service1.Name}";
            Client = $"{service.Client1.Name}";
            Date = $"{service.Date}";
        }
    }
}
