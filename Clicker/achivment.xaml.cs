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
    /// Логика взаимодействия для achivment.xaml
    /// </summary>
    public partial class achivment : Window
    {
        public achivment()
        {
            InitializeComponent();
        }

        private void ach_loaded (object sender, RoutedEventArgs e)
        {
            nm1.Text = "Начинающий" + "\n" + "собиратель";
        }
        private void ach1_Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Достижение 1";
            aboba.info.Text = "Напиши чё-нибудь";
            aboba.Show();
        }
    }
}
