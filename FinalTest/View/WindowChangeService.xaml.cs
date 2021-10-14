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
        public WindowChangeService()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Controll.ControllerAddService.AddChangeService(tbName.Text, tbPrice.Text, tbSale.Text, tbTime.Text))
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
    }
}
