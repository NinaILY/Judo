﻿using System;
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
    public partial class MainCtrl : Page
    {
        public MainCtrl() => InitializeComponent();
        void Uch_Click(object o, RoutedEventArgs e)
        {
            if (QueryBD.участник == null) QueryBD.участник = new Участники();
            QueryBD.Navigate(QueryBD.участник);
        }
        void GU_Click(object o, RoutedEventArgs e)
        {
            if (QueryBD.гручастник == null) QueryBD.гручастник = new ГруппаУчастников();
            QueryBD.Navigate(QueryBD.гручастник);
        }
        void Tat_Click(object o, RoutedEventArgs e)
        {
            if (QueryBD.tat == null) QueryBD.tat = new Татами();
            QueryBD.Navigate(QueryBD.tat);
        }
        void WindowCtrl_Click(object o, RoutedEventArgs e)
        {
            if (QueryBD.wCtrl == null) QueryBD.wCtrl = new WIndowCtrl();
            QueryBD.Navigate(QueryBD.wCtrl);
        }
    }
}
