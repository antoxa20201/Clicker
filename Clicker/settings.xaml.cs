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

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для settings.xaml
    /// </summary>
    public partial class settings : Window
    {
        public settings()
        {
            InitializeComponent();
        }
        public int check = 1;
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((MainWindow)Application.Current.MainWindow).player.Volume = slid.Value;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            slid.Value = ((MainWindow)Application.Current.MainWindow).player.Volume;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).player.Pause();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).player.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(check == 1)
            {
                ((MainWindow)Application.Current.MainWindow).player.Stop();
                ((MainWindow)Application.Current.MainWindow).player.Open(new Uri(((MainWindow)Application.Current.MainWindow).tr2, UriKind.Relative));
                ((MainWindow)Application.Current.MainWindow).player.Position = new TimeSpan(0, 0, 0, 0, 1);
                ((MainWindow)Application.Current.MainWindow).player.Play();
                check = 2;
            }
            else if (check == 2)
            {
                ((MainWindow)Application.Current.MainWindow).player.Stop();
                ((MainWindow)Application.Current.MainWindow).player.Open(new Uri(((MainWindow)Application.Current.MainWindow).tr3, UriKind.Relative));
                ((MainWindow)Application.Current.MainWindow).player.Position = new TimeSpan(0, 0, 0, 0, 1);
                ((MainWindow)Application.Current.MainWindow).player.Play();
                check = 3;
            }
            else if(check == 3)
            {
                ((MainWindow)Application.Current.MainWindow).player.Stop();
                ((MainWindow)Application.Current.MainWindow).player.Open(new Uri(((MainWindow)Application.Current.MainWindow).tr4, UriKind.Relative));
                ((MainWindow)Application.Current.MainWindow).player.Position = new TimeSpan(0, 0, 0, 0, 1);
                ((MainWindow)Application.Current.MainWindow).player.Play();
                check = 4;
            }
            else if(check == 4)
            {
                ((MainWindow)Application.Current.MainWindow).player.Stop();
                ((MainWindow)Application.Current.MainWindow).player.Open(new Uri(((MainWindow)Application.Current.MainWindow).tr1, UriKind.Relative));
                ((MainWindow)Application.Current.MainWindow).player.Position = new TimeSpan(0, 0, 0, 0, 1);
                ((MainWindow)Application.Current.MainWindow).player.Play();
                check = 1;
            }
        }
    }
}
