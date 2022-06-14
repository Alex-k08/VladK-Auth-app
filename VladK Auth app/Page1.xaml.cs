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

namespace VladK_Auth_app
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Войти_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Voity());
        }

        private void Зарегистрироваться_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Zaregistrirovatca());
        }
    }
}
