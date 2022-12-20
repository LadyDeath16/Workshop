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
    /// Логика взаимодействия для PageAdditionalEducation.xaml
    /// </summary>
    public partial class PageAdditionalEducation : Page
    {
        public PageAdditionalEducation()
        {
            InitializeComponent();
        }
        private void btnMorePython_Click(object sender, RoutedEventArgs e)
        {
            WindowPython threeWindow = new WindowPython();
            threeWindow.Show();
        }
        private void btnBackPageCourses_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCourses());
        }
    }
}
