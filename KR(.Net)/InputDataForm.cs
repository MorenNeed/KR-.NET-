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
    public partial class InputDataForm : Form
    {
        public InputDataForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.PaleVioletRed;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(128, 128, 255);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
