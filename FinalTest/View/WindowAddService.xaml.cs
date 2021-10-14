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
    /// Логика взаимодействия для WindowAddService.xaml
    /// </summary>
    public partial class WindowAddService : Window
    {
        public WindowAddService()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Controll.ControllerAddService.AddService(tbName.Text, tbPrice.Text, tbSale.Text, tbTime.Text))
                {
                    MessageBox.Show("Обьект добавлен");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            View.WindowService window = new WindowService();
            window.Show();
            this.Close();
        }
    }
}
