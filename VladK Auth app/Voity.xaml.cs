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
    /// Логика взаимодействия для Voity.xaml
    /// </summary>
    public partial class Voity : Page
    {
        public Voity()
        {
            InitializeComponent();
        }

        private void voity_Click(object sender, RoutedEventArgs e)
        {
            var db = new vlad_kEntities();
            var Users = db.Users.Where((user) => user.Login == Login.Text && user.Password == Password.Password).ToList();
            if (Users.Count > 0)
            {
                //Console.WriteLine(db.UserType.Find(Users[0].Type).name);
                Console.WriteLine(Users[0].UserType.name);
                if(Users[0].Type == 1)
                {
                    NavigationService.Navigate(new ForUser(Users[0]));
                }
                else if (Users[0].Type == 2)
                {
                    NavigationService.Navigate(new ForAdmin(Users[0]));
                }
            }
            else
            {
                MessageBox.Show("User is not found");
            }
        }
    }
}
