using FinalTest.View.ModelView;
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
    /// Логика взаимодействия для WindowServiceClient.xaml
    /// </summary>
    public partial class WindowServiceClient : Window
    {
        private static List<View.ModelView.ViewServiceClient> views = new List<ModelView.ViewServiceClient>();
        public WindowServiceClient()
        {
            InitializeComponent();
            views = GetServiceClient();
            Run(views);
        }

        private void Run(List<ViewServiceClient> views)
        {
            lbContent.ItemsSource = null;
            lbContent.ItemsSource = views;
        }

        private List<ViewServiceClient> GetServiceClient()
        {
            try
            {
                return Controll.ControllServiceClient.GetServiceClient();
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            View.WindowAddServiceClient windowAddServiceClient = new WindowAddServiceClient();
            windowAddServiceClient.Show();
            this.Close();
        }
    }
}
