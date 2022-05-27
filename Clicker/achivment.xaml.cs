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
            nm1.Text = "Начинающий" + "\n" + "пекарь";
            nm2.Text = "Опытный" + "\n" + "пекарь";
            nm3.Text = "Мастер" + "\n" + "пекарь";
            nm4.Text = "Бог" + "\n" + "печенья";
            nm5.Text = "Супер" + "\n" + "Клик";
            nm6.Text = "Ленивый" + "\n" + "Пекарь";
            nm7.Text = "Плотный" + "\n" + "закуп";
            nm8.Text = "Секрет";
               
        }
        private void ach1_Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Начинающий пекарь";
            aboba.info.Text = "Собрать 10000 печенья";
            aboba.Show();
        }

        private void ach2_Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Опытный пекарь";
            aboba.info.Text = "Собрать в сумме 100000";
            aboba.Show();
        }

        private void ach3_Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Пекарь мастер";
            aboba.info.Text = "Собрать в сумме 500000 печенья";
            aboba.Show();
        }

        private void ach4Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Бог печенья";
            aboba.info.Text = "Собрать в сумме 1000000 печенья";
            aboba.Show();
        }

        private void ach5_Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Супер клик";
            aboba.info.Text = "Купить пятое улучшение клика";
            aboba.Show();
        }

        private void ach6_Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Ленивый Пекарь";
            aboba.info.Text = "купить пятое улучшение тиков";
            aboba.Show();
        }

        private void ach7_Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Плотный закуп";
            aboba.info.Text = "Прокачать первое улучшение клика до" + "\n" +  "100 уровня";
            aboba.Show();
        }

        private void ach8_Click(object sender, RoutedEventArgs e)
        {
            achivment1 aboba = new achivment1();
            aboba.Title = "Секретная";
            aboba.info.Text = "Найти секретную кнопку";
            aboba.Show();
        }
    }
}
