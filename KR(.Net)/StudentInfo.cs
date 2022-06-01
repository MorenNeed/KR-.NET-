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
