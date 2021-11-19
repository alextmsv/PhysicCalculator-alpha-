using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalPhysicCalculator
{
    public partial class strengthForm : Form
    {
        public strengthForm()
        {
            InitializeComponent();
            tmr_emulation.Enabled = false;
            mass.Minimum = 0;
            height.Minimum = 1;
        }
        
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }
       

        private void progressBar1_Click(object sender, EventArgs e)
        {
             
        }
        
        private void strengthForm_Load(object sender, EventArgs e)
        {

        }

        private void mass_ValueChanged(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void verticalProgressBar1_Click(object sender, EventArgs e)
        {
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            tmr_emulation.Enabled = true;
        }
        private void tmr_emulation_Tick(object sender, EventArgs e)
        {
            verticalProgressBar1.Maximum = (int)height.Value;
            int g = 10; //ускорение свободного падения (округленное)
            double H = (double)mass.Value * 9.80; //кг в ньютон   
            double speed = Math.Sqrt(2*g*(double)height.Value);
            int magic = (int)speed; // убирает остаток
            int strength = (int)((double)mass.Value*g*H/(double)height.Value);
            if (verticalProgressBar1.Maximum < magic)
            {
                tmr_emulation.Enabled = false;
                speedText.Text = magic.ToString() + " м/с";
                strengthText.Text = (strength + " кг").ToString();
                MessageBox.Show("Ваш объект упал за мгновенье!", "Симуляция завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verticalProgressBar1.Value = 0;
                return;
            }
            
            verticalProgressBar1.Value += magic;
            if (verticalProgressBar1.Value + magic >= verticalProgressBar1.Maximum)
            {
                tmr_emulation.Enabled = false;
                MessageBox.Show("Упал", "Симуляция завершена", MessageBoxButtons.OK);
                verticalProgressBar1.Value = 0;
                return;
            } 
            speedText.Text = magic.ToString() + " м/с";
            strengthText.Text = (strength + " кг").ToString();

            timeText.Text = ((int)height.Value / magic).ToString() + " сек";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void strengthText_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
