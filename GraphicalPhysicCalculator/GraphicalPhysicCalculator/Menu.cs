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
    public partial class Menu : System.Windows.Forms.Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(timeCalc, "Эта функция вычисляет время при имеющиеся растоянии и скорости, эмулируя в виде ProgressBar(загрузки)");
        }


        private void timeCalc_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            distanceForm dst = new distanceForm();
            this.Hide();
            dst.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeedForm speedform = new SpeedForm();
            this.Hide();
            speedform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            strengthForm strengthForm = new strengthForm();
            this.Hide();
            strengthForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            massForm massForm = new massForm();
            this.Hide();
            massForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            heightForm heightForm = new heightForm();
            this.Hide();
            heightForm.Show();
        }
    }
}
