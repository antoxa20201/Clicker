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
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
            


        }

        private void Menu_Loaded (object sender, RoutedEventArgs e)
        {
            lvla();
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick1)
            {
                cl1.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick1)
            {
                cl1.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick2)
            {
                cl2.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick2)
            {
                cl2.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick3)
            {
                cl3.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick3)
            {
                cl3.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick4)
            {
                cl4.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick4)
            {
                cl4.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick5)
            {
                cl5.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick5)
            {
                cl5.IsEnabled = true;
            }


            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times1)
            {
                tl1.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times1)
            {
                tl1.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times2)
            {
                tl2.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times2)
            {
                tl2.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times3)
            {
                tl3.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times3)
            {
                tl3.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times4)
            {
                tl4.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times4)
            {
                tl4.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times5)
            {
                tl5.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times5)
            {
                tl5.IsEnabled = true;
            }
        }


        private void cl1_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).n += 1;
            ((MainWindow)Application.Current.MainWindow).clvl1++;
            c1.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl1.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).sclick1;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).sclick1 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).sclick1) * 1.1);
            cl1.Content = ((MainWindow)Application.Current.MainWindow).sclick1;
            proverka();
        }

        private void cl2_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).n += 5;
            ((MainWindow)Application.Current.MainWindow).clvl2++;
            c2.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl2.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).sclick2;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).sclick2 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).sclick2) * 1.1);
            cl2.Content = ((MainWindow)Application.Current.MainWindow).sclick2;
            proverka();
        }

        private void cl3_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).n += 10;
            ((MainWindow)Application.Current.MainWindow).clvl3++;
            c3.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl3.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).sclick3;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).sclick3 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).sclick3) * 1.1);
            cl3.Content = ((MainWindow)Application.Current.MainWindow).sclick3;
            proverka();
        }

        private void cl4_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).n += 50;
            ((MainWindow)Application.Current.MainWindow).clvl4++;
            c4.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl4.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).sclick4;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).sclick4 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).sclick4) * 1.1);
            cl4.Content = ((MainWindow)Application.Current.MainWindow).sclick4;
            proverka();
        }

        private void cl5_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).n += 100;
            ((MainWindow)Application.Current.MainWindow).clvl5++;
            c5.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl5.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).sclick5;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).sclick5 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).sclick5) * 1.1);
            cl5.Content = ((MainWindow)Application.Current.MainWindow).sclick5;
            proverka();
        }

        private void tl1_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).t += 1;
            ((MainWindow)Application.Current.MainWindow).tlvl1++;
            t1.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl1.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).times1;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).times1 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).times1) * 1.1);
            tl1.Content = ((MainWindow)Application.Current.MainWindow).times1;
            proverka();
        }

        private void tl2_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).t += 5;
            ((MainWindow)Application.Current.MainWindow).tlvl2++;
            t2.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl2.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).times2;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).times2 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).times2) * 1.1);
            tl2.Content = ((MainWindow)Application.Current.MainWindow).times2;
            proverka();
        }

        private void tl3_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).t += 10;
            ((MainWindow)Application.Current.MainWindow).tlvl3++;
            t2.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl2.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).times3;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).times3 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).times3) * 1.1);
            tl3.Content = ((MainWindow)Application.Current.MainWindow).times3;

            proverka();
        }

        private void tl4_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).t += 50;
            ((MainWindow)Application.Current.MainWindow).tlvl4++;
            t2.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl2.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).times4;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).times4 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).times4) * 1.1);
            tl4.Content = ((MainWindow)Application.Current.MainWindow).times4;
            proverka();
        }

        private void tl5_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).t += 100;
            ((MainWindow)Application.Current.MainWindow).tlvl5++;
            t5.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl5.ToString();
            ((MainWindow)Application.Current.MainWindow).click -= ((MainWindow)Application.Current.MainWindow).times5;
            ((MainWindow)Application.Current.MainWindow).click_Counter.Text = ((MainWindow)Application.Current.MainWindow).click.ToString();
            ((MainWindow)Application.Current.MainWindow).times5 = Convert.ToInt32(Convert.ToDouble(((MainWindow)Application.Current.MainWindow).times5) * 1.1);
            tl5.Content = ((MainWindow)Application.Current.MainWindow).times5;
            proverka();
        }
        private void proverka()
        {
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick1)
            {
                cl1.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick1)
            {
                cl1.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick2)
            {
                cl2.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick2)
            {
                cl2.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick3)
            {
                cl3.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick3)
            {
                cl3.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick4)
            {
                cl4.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick4)
            {
                cl4.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).sclick5)
            {
                cl5.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).sclick5)
            {
                cl5.IsEnabled = true;
            }


            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times1)
            {
                tl1.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times1)
            {
                tl1.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times2)
            {
                tl2.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times2)
            {
                tl2.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times3)
            {
                tl3.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times3)
            {
                tl3.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times4)
            {
                tl4.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times4)
            {
                tl4.IsEnabled = true;
            }
            if (((MainWindow)Application.Current.MainWindow).click < ((MainWindow)Application.Current.MainWindow).times5)
            {
                tl5.IsEnabled = false;
            }
            else if (((MainWindow)Application.Current.MainWindow).click >= ((MainWindow)Application.Current.MainWindow).times5)
            {
                tl5.IsEnabled = true;
            }
        }
        private void lvla()
        {
            c1.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl1.ToString();
            c2.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl2.ToString();
            c3.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl3.ToString();
            c4.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl4.ToString();
            c5.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).clvl5.ToString();

            t1.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl1.ToString();
            t2.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl2.ToString();
            t3.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl3.ToString();
            t4.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl4.ToString();
            t5.Text = "lvl" + ((MainWindow)Application.Current.MainWindow).tlvl5.ToString();

            cl1.Content = ((MainWindow)Application.Current.MainWindow).sclick1;
            cl2.Content = ((MainWindow)Application.Current.MainWindow).sclick2;
            cl3.Content = ((MainWindow)Application.Current.MainWindow).sclick3;
            cl4.Content = ((MainWindow)Application.Current.MainWindow).sclick4;
            cl5.Content = ((MainWindow)Application.Current.MainWindow).sclick5;

            tl1.Content = ((MainWindow)Application.Current.MainWindow).times1;
            tl2.Content = ((MainWindow)Application.Current.MainWindow).times2;
            tl3.Content = ((MainWindow)Application.Current.MainWindow).times3;
            tl4.Content = ((MainWindow)Application.Current.MainWindow).times4;
            tl5.Content = ((MainWindow)Application.Current.MainWindow).times5;
        }
    }
}
