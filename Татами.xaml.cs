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
    public partial class Татами : Page
    {
        public Татами()
        {
            InitializeComponent();
            lb.ItemsSource = QueryBD.bd.Tatami.ToArray();
            if (lb.Items.Count != 0) lb.SelectedIndex = 0;
            Update();
        }

        public void Update()
        {
            if (lb.Items.Count != 0)
            {
                var tat = (lb.SelectedItem as Tatami).id_tatami;
                Tat.ItemsSource = QueryBD.bd.UchastChamp.Where(s => s.ChampionatConfig.Tatami.id_tatami == tat).ToList();
            }
        }

        void lb_SelectionChanged(object o, SelectionChangedEventArgs e) => Update();
    }
}
