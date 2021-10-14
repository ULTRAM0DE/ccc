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
    /// Логика взаимодействия для WindowClient.xaml
    /// </summary>
    public partial class WindowClient : Window
    {
        private static List<View.ModelView.ViewClient> views = new List<ModelView.ViewClient>();
        public WindowClient()
        {
            InitializeComponent();
            views = GetClient();
            Run(views);
        }

        private void Run(List<ViewClient> views)
        {
            lbContent.ItemsSource = null;
            lbContent.ItemsSource = views;
        }

        private List<ViewClient> GetClient()
        {
            try
            {
                return Controll.ControllClient.GetClient();
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            View.WindowAddClient client = new WindowAddClient();
            client.Show();
            this.Close();
        }
    }
}
