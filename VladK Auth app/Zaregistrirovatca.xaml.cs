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
    /// Логика взаимодействия для Zaregistrirovatca.xaml
    /// </summary>
    public partial class Zaregistrirovatca : Page
    {
        public Zaregistrirovatca()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text.Length != 0 && Login.Text != "" && Password.Password.Length != 0 && Password.Password != "" )
            {
                if (Password.Password == Povtorite.Password)
                {
                    var db = (new vlad_kEntities());

                    var user = new Users();
                    user.Login = Login.Text;
                    user.Password = Password.Password;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
        }
    }
}
