using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_.Net_
{
    public partial class CalculateMenu : Form
    {
        public CalculateMenu()
        {
            InitializeComponent();
        }
        public double f1(double x, double q, double a)
        {

            double f1;
            f1 = (Math.Log(q * Math.Sin(a - x)) / (q + x));
            return f1;
        }
        public double f2(double x, double q, double a)
        {
            double f2;
            f2 = Math.Sqrt(Math.Sqrt(q - a)) * x;
            return f2;
        }

        private bool isMousePress = false;
        private Point _clickPoint;
        private Point _formStartPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePress)
            {
                var cursorOffsetPoint = new Point( //считаем смещение курсора от старта
                    Cursor.Position.X - _clickPoint.X,
                    Cursor.Position.Y - _clickPoint.Y);

                Location = new Point( //смещаем форму от начальной позиции в соответствии со смещением курсора
                    _formStartPoint.X + cursorOffsetPoint.X,
                    _formStartPoint.Y + cursorOffsetPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            _clickPoint = Point.Empty;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            InputDataForm form = new InputDataForm();
            if (form.listBox_f1.Items.Count != 0)
            {
                form.listBox_f1.Items.Clear();
            }
            if (form.listBox_f2.Items.Count != 0)
            {
                form.listBox_f2.Items.Clear();
            }
            Random rd = new Random();
            double xmin, xmax, dx, q, func, x;
            const double a = 0.5;
            int cilc_f1 = 0;
            int cilc_f2 = 0;
            int cilc_def_f1 = 0;
            int cilc_def_f2 = 0;
            try
            {
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
                            form.listBox_f1.Items.Add(func);
                            cilc_f1++;
                        }
                        else
                        {
                            form.listBox_f1.Items.Add("∅");
                            cilc_def_f1++;
                        }
                    }
                    else if (q > 0.25 && q <= 1)
                    {
                        if (Math.Sqrt(q - a) >= 0)
                        {
                            func = f2(x, q, a);
                            form.listBox_f2.Items.Add(func);
                            cilc_f2++;
                        }
                        else
                        {
                            form.listBox_f2.Items.Add("∅");
                            cilc_def_f2++;
                        }
                    }
                    x += dx;
                } while (x <= xmax);

                form.Num_f1.Text = $"Number of calculations of f1(x) : {cilc_f1}";
                form.Num_f2.Text = $"Number of calculations of f2(x) : {cilc_f2}";
                form.def_f1.Text = $"Number of defined expressions of f1(x) : {cilc_def_f1}";
                form.def_f2.Text = $"Number of defined expressions of f2(x) : {cilc_def_f2}";

                this.Hide();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + char.ConvertFromUtf32(13) + "Неправильно введені дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void X_MouseEnter(object sender, EventArgs e)
        {
            X.BackColor = Color.PaleVioletRed;
        }

        private void X_MouseLeave(object sender, EventArgs e)
        {
            X.BackColor = Color.FromArgb(128, 255, 128);
        }
    }
}
