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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (listBox_f1.Items.Count != 0)
            {
                listBox_f1.Items.Clear();
            }
            if (listBox_f2.Items.Count != 0)
            {
                listBox_f2.Items.Clear();
            }
            Random rd = new Random();
            double xmin, xmax, dx, q, func, x;
            const double a = 0.5;
            int cilc_f1 = 0;
            int cilc_f2 = 0;
            int cilc_def_f1 = 0;
            int cilc_def_f2 = 0;
            xmin = Convert.ToDouble(textBox_xmin.Text);
            xmax = Convert.ToDouble(textBox_xmax.Text);
            dx = Convert.ToDouble(textBox_dx.Text);

            x = xmin;
            do
            {
                q = rd.NextDouble();

                if (q > 0 && q <= 0.25)
                {
                    if (Math.Sin(a - x) != 0 && (q + x) != 0 && q * Math.Sin(a - x) > 0)
                    {
                        func = f1(x, q, a);
                        listBox_f1.Items.Add(func);
                        cilc_f1++;
                    }
                    else
                    {
                        listBox_f1.Items.Add("∅");
                        cilc_def_f1++;
                    }
                }
                else if (q > 0.25 && q <= 1)
                {
                    if (Math.Sqrt(q - a) >= 0)
                    {
                        func = f2(x, q, a);
                        listBox_f2.Items.Add(func);
                        cilc_f2++;
                    }
                    else
                    {
                        listBox_f2.Items.Add("∅");
                        cilc_def_f2++;
                    }
                }
                x += dx;
            } while (x <= xmax);

            Num_f1.Text = $"Number of calculations of f1(x) : {cilc_f1}";
            Num_f2.Text = $"Number of calculations of f2(x) : {cilc_f2}";
            def_f1.Text = $"Number of defined expressions of f1(x) : {cilc_def_f1}";
            def_f2.Text = $"Number of defined expressions of f2(x) : {cilc_def_f2}";
            */
        }
    }
}
