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

namespace Judo
{
    public partial class УчастникMode : Window
    {
        participants uch;
        public УчастникMode(participants uc)
        {
            DataContext = uc;
            uch = uc;
            InitializeComponent();
            if (uch?.Gender[0] == 'f')
                GenderF.IsChecked = true;
        }

        void Apply_Click(object sender, RoutedEventArgs e)
        {
            if (QueryBD.user == null) Close();
            if (name.Text == "" || Birthday.SelectedDate == null || Sportclub.Text == "" || WT.Text == "0") return;
            if (uch == null)
            {
                uch = new participants();
                QueryBD.bd.participants.Add(uch);
            }

            uch.Name = name.Text;
            uch.Gender = GenderM.IsChecked.Value ? "f" : "m";
            uch.Birthday = Birthday.SelectedDate.Value.ToString();
            uch.Birthtown = Birthtown.Text;
            uch.Street = Street.Text;
            uch.Sportsclub = Sportclub.Text;
            uch.Hometown = Hometown.Text;
            uch.Weight_kg = Convert.ToInt32(WT.Text.Split('.')[0]);

            QueryBD.bd.SaveChanges();
            QueryBD.участник.Update();
            Close();
        }

        void Close_Click(object sender, RoutedEventArgs e) => Close();
    }
}
