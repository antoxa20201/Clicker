using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

        internal MediaPlayer player = new MediaPlayer();
        public int click = 0;
        public string saves = "SavesQ";


        internal int sum = 0;
        internal int n = 1;
        internal int t = 0;
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

        internal int clvl1 = 0;
        internal int clvl2 = 0;
        internal int clvl3 = 0;
        internal int clvl4 = 0;
        internal int clvl5 = 0;

        internal int tlvl1 = 0;
        internal int tlvl2 = 0;
        internal int tlvl3 = 0;
        internal int tlvl4 = 0;
        internal int tlvl5 = 0;

        internal string tr1 = "Vishnu - Patrick Patrikios.mp3";
        internal string tr2 = "Icelandic Arpeggios - DivKid.mp3";
        internal string tr3 = "Voices - Patrick Patrikios.mp3";
        internal string tr4 = "We Bubbles - Freedom Trail Studio.mp3";

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

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            click += n;
            sum += n;
            click_Counter.Text = click.ToString();
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            settings srt = new settings();
            srt.Title = "Settings";
            srt.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            srt.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            player.Open(new Uri(tr1, UriKind.Relative));
            player.Position = new TimeSpan(0, 0, 0, 0, 1);
            player.Volume = 0.1;
            player.Play();
            if (File.Exists(saves)){
                using (var sr = new StreamReader(saves))
                {
                    click = Convert.ToInt32(sr.ReadLine());
                    n = Convert.ToInt32(sr.ReadLine());
                    t = Convert.ToInt32(sr.ReadLine());
                    clvl1 = Convert.ToInt32(sr.ReadLine());
                    clvl2 = Convert.ToInt32(sr.ReadLine());
                    clvl3 = Convert.ToInt32(sr.ReadLine());
                    clvl4 = Convert.ToInt32(sr.ReadLine());
                    clvl5 = Convert.ToInt32(sr.ReadLine());
                    tlvl1 = Convert.ToInt32(sr.ReadLine());
                    tlvl2 = Convert.ToInt32(sr.ReadLine());
                    tlvl3 = Convert.ToInt32(sr.ReadLine());
                    tlvl4 = Convert.ToInt32(sr.ReadLine());
                    tlvl5 = Convert.ToInt32(sr.ReadLine());
                }
            }
        }

        void SaveFile(string saves_)
        {
            string[] stringsaves = new string[]
            {
                click.ToString(),
                n.ToString(),
                t.ToString(),
                clvl1.ToString(),
                clvl2.ToString(),
                clvl3.ToString(),
                clvl4.ToString(),
                clvl5.ToString(),
                tlvl1.ToString(),
                tlvl2.ToString(),
                tlvl3.ToString(),
                tlvl4.ToString(),
                tlvl5.ToString()
            };
            if (File.Exists(saves_))
            {
                File.Delete(saves_);
            }
            File.AppendAllLines(saves, stringsaves);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveFile(saves);
        }
    }
}
