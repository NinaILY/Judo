using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class TbGroup
    {
        public ChampionatConfig conf { get; set; }
        public int OrderGroup { get; set; }
        public UchastChamp uch1 { get; set; }
        public UchastChamp uch2 { get; set; }
        public UchastChamp uch3 { get; set; }
    }
    public class convert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
                if ((value as string).IndexOf("m") != -1) return "Муж";
                else return "Жен";
            else return "Жен";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public partial class TableGroup : UserControl
    {
        public TableGroup(TbGroup tb)
        {
            DataContext = tb;
            InitializeComponent();
            if (tb.uch1 != null && tb.uch2 != null || tb.uch3 != null)
            {
                if (tb.uch2 != null)
                {
                    Win12.Content = GetCountWinGroup(tb.uch1) != 0 ? tb.uch1.participants.Name : tb.uch2.participants.Name;
                    Win21.Content = Win12.Content;
                }
                if (tb.uch3 != null)
                {
                    Win13.Content = GetCountWinGroup(tb.uch1) != 0 ? tb.uch1.participants.Name : tb.uch3.participants.Name;
                    Win31.Content = Win13.Content;
                }
                if (tb.uch2 != null && tb.uch3 != null)
                {
                    Win23.Content = GetCountWinGroup(tb.uch2) != 0 ? tb.uch2.participants.Name : tb.uch3.participants.Name;
                    Win32.Content = Win23.Content;
                }
                int GetCountWinGroup(UchastChamp uc) => uc.Sorevnovanie.Where(u => u.Winner == 0 && u.Red == uc.id_uchast || u.Winner == 1 && u.White == uc.id_uchast).Count();
            }
        }
    }
}
