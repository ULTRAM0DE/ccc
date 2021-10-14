using FinalTest.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.View.ModelView
{
    public class ViewSerrvice
    {
        public Service Service { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Time { get; set; }
        public string Price { get; set; }
        public string Sale { get; set; }

        public ViewSerrvice(DB.Service service)
        {
            Service = service;
            Name = $"Название услуги:{service.Name}";
            Time = $"Время выполнения:{service.Time}";
            Price = $"Цена услуги:{service.Price}";
            Sale = $"Скидка:{service.Sale}";
            ImagePath = string.IsNullOrWhiteSpace(service.ImagePath) ? @"/Услуги автосервиса\no image.png":service.ImagePath;
        }
    }
}
