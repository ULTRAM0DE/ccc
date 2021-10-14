using FinalTest.DB;
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
    /// Логика взаимодействия для WindowChangeService.xaml
    /// </summary>
    public partial class WindowChangeService : Window
    {
        public View.ModelView.ViewSerrvice Service { get; }
        public WindowChangeService()
        {
            InitializeComponent();
        }
        public WindowChangeService(ModelView.ViewSerrvice service) : this()
        {
            Service = service;
            tbName.Text = Service.Service.Name;
            tbPrice.Text = Convert.ToString(Service.Service.Price);
            tbSale.Text = Convert.ToString(Service.Service.Sale);
            tbTime.Text = Convert.ToString(Service.Service.Time);
        }
        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Controll.ControllerAddService.AddChangeService(tbName.Text, tbPrice.Text, tbSale.Text, tbTime.Text, Service.Service))
                {
                    MessageBox.Show("Обьект добавлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            View.WindowService service = new WindowService();
            service.Show();
            this.Close();
        }

        private void btRemove_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
