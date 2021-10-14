using FinalTest.DB;
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
    /// Логика взаимодействия для WindowService.xaml
    /// </summary>
    public partial class WindowService : Window
    {
        public View.ModelView.ViewSerrvice Service { get;}
        private static List<View.ModelView.ViewSerrvice> serrvices = new List<ModelView.ViewSerrvice>();
        public WindowService()
        {
            InitializeComponent();
            lbContent.MouseDoubleClick += LbContent_MouseDoubleClick;
            serrvices = GetService();
            Run(serrvices);
        }

        private void LbContent_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var sours = e.OriginalSource as Border;
            if (sours == null)
            {
                return;
            }
            var service = sours.DataContext as View.ModelView.ViewSerrvice;
            View.WindowChangeService windowChangeService = new WindowChangeService(service);
            windowChangeService.Show();
            this.Close();
        }

        

        private void Run(List<ViewSerrvice> serrvices)
        {
            lbContent.ItemsSource = null;
            lbContent.ItemsSource = serrvices;
        }

        private List<ViewSerrvice> GetService()
        {
            try
            {
                return Controll.ControllerService.GetService();
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            View.WindowAddService windowAddService = new WindowAddService();
            windowAddService.Show();
            this.Close();
        }
        

        private void btDn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

       
    }
}
