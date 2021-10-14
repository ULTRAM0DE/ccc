using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.View.ModelView
{
    class ViewClient
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Day_registration { get; set; }

        public ViewClient(DB.Client client)
        {
            Name = $"Имя:{client.Name} | Фамилия:{client.SurName} | Отчество:{client.LastName} | День рождения:{client.Birthday}";
            Phone = $"Телефон:{client.Phone}";
            Email = $"Email:{client.Email}";
            Day_registration = $"Дата регистрации:{client.Day_registration}";
            
            
        }
    }
}
