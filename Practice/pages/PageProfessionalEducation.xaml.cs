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
    /// Логика взаимодействия для PageProfessionalEducation.xaml
    /// </summary>
    public partial class PageProfessionalEducation : Page
    {
        public PageProfessionalEducation()
        {
            InitializeComponent();
        }
        private void btnMoreComputer_Click(object sender, RoutedEventArgs e)
        {
            WindowComputer oneWindow = new WindowComputer();
            oneWindow.Show();
        }
        private void btnMoreDigitalCurator_Click(object sender, RoutedEventArgs e)
        {
            WindowDigitalCurator twoWindow = new WindowDigitalCurator();
            twoWindow.Show();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCourses());
        }
    }
}
