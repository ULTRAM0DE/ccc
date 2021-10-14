using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Controll
{
    class ControllAddClient
    {
        internal static bool AddClient(string name,string surname, string lastname,string email,string birthaday,string day_registration, string phone)
        {
            DB.Client client = new DB.Client();
            try
            {
                client.Name = name;
                client.SurName = surname;
                client.LastName = lastname;
                client.Email = email;
                client.Birthday = Convert.ToDateTime(birthaday);
                client.Day_registration = Convert.ToDateTime(day_registration);
                client.Phone = phone;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
            if (client == null)
            {
                return false;
            }
            try
            {
                DB.TsaplinEntities entities = new DB.TsaplinEntities();
                entities.Client.Add(client);
                entities.SaveChanges();
                return true;
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }
    }
}
