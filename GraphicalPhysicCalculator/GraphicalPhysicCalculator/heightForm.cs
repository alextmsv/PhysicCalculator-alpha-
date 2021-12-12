using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalPhysicCalculator
{
    public partial class heightForm : Form
    {
        public heightForm()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void heightForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int g = 10;
        private void start_Click(object sender, EventArgs e)
        {
            double h = (int)time.Value*(int)time.Value * 5; // h = t^2 * g / 2 = 5*t^2
            label1.Text = "h (высота) = " + h.ToString() +" м";
        }
    }
}
