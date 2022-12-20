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
    /// Логика взаимодействия для PageCourses.xaml
    /// </summary>
    public partial class PageCourses : Page
    {
        public PageCourses()
        {
            InitializeComponent();
        }
        private void btnProfessionalEducation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageProfessionalEducation());
        }
        private void btnAdditionalEducation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAdditionalEducation());
        }
        private void btnAdvancedTraining_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAdvancedTraining());
        }
        private void btnAdditionalPrograms_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAdditionalPrograms());
        }
    }
}
