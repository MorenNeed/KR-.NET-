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
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculateMenu calc = new CalculateMenu();
            calc.ShowDialog();
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
            X.BackColor = Color.FromArgb(255, 255, 128);
        }
    }
}
