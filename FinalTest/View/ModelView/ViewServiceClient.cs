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
            Service = $"Название услуги:{service.Service1.Name} | Цена:{service.Service1.Price}";
            Client = $"Имя;{service.Client1.Name} | Фамилия:{service.Client1.SurName} | Отчество:{service.Client1.LastName}";
            Date = $"Дата:{service.Date}";
        }
    }
}
