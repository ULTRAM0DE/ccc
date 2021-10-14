using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalTest.View
{
    /// <summary>
    /// Логика взаимодействия для WindowAddClient.xaml
    /// </summary>
    public partial class WindowAddClient : Window
    {
        public WindowAddClient()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Controll.ControllAddClient.AddClient(tbName.Text, tbSurName.Text, tbLastName.Text, tbEmail.Text, tbBirthaday.Text, tbDay_Registration.Text, tbPhone.Text))
                {
                    MessageBox.Show("Клиент добавлен");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            View.WindowClient client = new WindowClient();
            client.Show();
            this.Close();
        }
    }
}
