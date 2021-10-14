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
        private static List<View.ModelView.ViewSerrvice> serrvices = new List<ModelView.ViewSerrvice>();
        public WindowService()
        {
            InitializeComponent();
            
            serrvices = GetService();
            Run(serrvices);
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

        private void btChange_Click(object sender, RoutedEventArgs e)
        {
            var sours = e.OriginalSource as Button;
            if(sours == null)
            {
                return;
            }
            var service = sours.DataContext as Button;
            View.WindowChangeService windowChangeService = new WindowChangeService();
            windowChangeService.Show();
            this.Close();
        }
    }
}
