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
using System.Windows.Threading;

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

        }
        public int click = 0;
        
        internal int sum = 0;
        internal int n = 1;
        internal int t = 1;
        internal int plus = 1;
        internal int sclick1 = 10;
        internal int sclick2 = 100;
        internal int sclick3 = 500;
        internal int sclick4 = 1000;
        internal int sclick5 = 5000;
        internal int times1 = 10;
        internal int times2 = 100;
        internal int times3 = 500;
        internal int times4 = 1000;
        internal int times5 = 5000;

        internal int clvl1 = 1;
        internal int clvl2 = 1;
        internal int clvl3 = 1;
        internal int clvl4 = 1;
        internal int clvl5 = 1;

        internal int tlvl1 = 1;
        internal int tlvl2 = 1;
        internal int tlvl3 = 1;
        internal int tlvl4 = 1;
        internal int tlvl5 = 1;






        private void timer_Tick(object sender, EventArgs e)
        {
            click += t;
            sum += t;
            click_Counter.Text = click.ToString();
        }

        

   

        private void openmenu_Click(object sender, RoutedEventArgs e)
        {
            menu mainmenu = new menu();
            mainmenu.Title = "Menu";
            mainmenu.Show();
            mainmenu.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            
        }

        private void machivment_Click(object sender, RoutedEventArgs e)
        {
            achivment ach = new achivment();
            ach.Title = "Достижения";
            ach.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            ach.Show();

        }
        private void menu_click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            click += n;
            sum += n;
            click_Counter.Text = click.ToString();
        }
    }
}
