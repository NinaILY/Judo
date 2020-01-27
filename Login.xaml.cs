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

namespace Judo
{
    public partial class Login : Page
    {
        public Login() => InitializeComponent();
        void Login_Click(object o, RoutedEventArgs e)
        {
            if (login.Text == "" || Password.Password == "") return;
            var pass = QueryBD.GetMd5Hash(Password.Password);
            if (QueryBD.bd.User.Where(u => u.Login == login.Text && u.Password == pass).Count() != 0)
            {
                if (QueryBD.mainctrl == null) QueryBD.mainctrl = new MainCtrl();
                QueryBD.Navigate(QueryBD.mainctrl);
            }
        }
        void Reg_Click(object o, RoutedEventArgs e)
        {
            if (QueryBD.reg == null) QueryBD.reg = new Registration();
            QueryBD.Navigate(QueryBD.reg);
        }
        void Reset_Click(object sender, RoutedEventArgs e)
        {
            if (QueryBD.res == null) QueryBD.res = new Reset();
            QueryBD.Navigate(QueryBD.res);
        }
    }
}
