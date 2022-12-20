using Practice.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice.pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdditionalPrograms.xaml
    /// </summary>
    public partial class PageAdditionalPrograms : Page
    {
        public PageAdditionalPrograms()
        {
            InitializeComponent();
        }
        private void btnMoreComputerLiteracy_Click(object sender, RoutedEventArgs e)
        {
            WindowComputerLiteracy fiveWindow = new WindowComputerLiteracy();
            fiveWindow.Show();
        }
        private void btnMoreWebDesign_Click(object sender, RoutedEventArgs e)
        {
            WindowWebDesign sixWindow = new WindowWebDesign();
            sixWindow.Show();
        }
        private void btnMoreVIAR_Click(object sender, RoutedEventArgs e)
        {
            WindowVIAR sevenWindow = new WindowVIAR();
            sevenWindow.Show();
        }
        private void btnMoreComputerNetworks_Click(object sender, RoutedEventArgs e)
        {
            WindowComputerNetworks eightWindow = new WindowComputerNetworks();
            eightWindow.Show();
        }
        private void btnMorePython_Click(object sender, RoutedEventArgs e)
        {
            WindowPython nineWindow = new WindowPython();
            nineWindow.Show();
        }
        private void btnMore3DModeling_Click(object sender, RoutedEventArgs e)
        {
            Window3DModeling tenWindow = new Window3DModeling();
            tenWindow.Show();
        }
        private void BtnBackPageCourses_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCourses());
        }
    }
}
