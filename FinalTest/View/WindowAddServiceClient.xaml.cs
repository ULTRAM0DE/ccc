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
    /// Логика взаимодействия для WindowAddServiceClient.xaml
    /// </summary>
    public partial class WindowAddServiceClient : Window
    {
        public WindowAddServiceClient()
        {
            InitializeComponent();
            this.Loaded += WindowAddServiceClient_Loaded;
        }

        private void WindowAddServiceClient_Loaded(object sender, RoutedEventArgs e)
        {
            cbService.ItemsSource = Controll.ServiceClientId.GetService();
            cbClient.ItemsSource = Controll.ServiceClientId.GetClient();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Controll.ControllerAddServiceClient.AddServiceClient(cbService.SelectedItem, cbClient.SelectedItem, tbDate.Text))
                {
                    MessageBox.Show("Клиент записан");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            View.WindowServiceClient window = new WindowServiceClient();
            window.Show();
            this.Close();
        }
    }
}
