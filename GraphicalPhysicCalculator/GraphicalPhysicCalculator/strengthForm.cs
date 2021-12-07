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
            
            
            int g = 10; //ускорение свободного падения (округленное)
            double HtoKG = 0.101; //ньютон в массу (веденную массу умножаем на это число и получится сила удара в кг; округленное)
            double time = Math.Sqrt(2*(double)height.Value/g);
            double speed = Math.Sqrt(2*g*(double)height.Value);
            int a = 10; //speed / time; вектор ускорения a=v(скорость)/t(время) 
            double strength = (double)mass.Value * a * HtoKG; // F = ma (mv/t) * HtoKG (переводим в "кг")
            verticalProgressBar1.Maximum = (int)(speed*time);
            if (verticalProgressBar1.Maximum < (int)speed) // альтернативы пока не нашел
            {
                tmr_emulation.Enabled = false;
                speedText.Text = ((int)speed).ToString() + " м/с";
                strengthText.Text = (strength + " кг").ToString();
                timeText.Text = ((int)time).ToString() + " сек";
                MessageBox.Show("Ваш объект упал за мгновенье!", "Симуляция завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verticalProgressBar1.Value = 0;
                return;
            }
            verticalProgressBar1.Value += (int)speed;
            if (verticalProgressBar1.Value + (int)speed >= verticalProgressBar1.Maximum)
            {
                tmr_emulation.Enabled = false;
                MessageBox.Show("Упал", "Симуляция завершена", MessageBoxButtons.OK);
                verticalProgressBar1.Value = 0;
                return;
            } 
            speedText.Text = ((int)speed).ToString() + " м/с";
            strengthText.Text = (strength + " кг").ToString();

            timeText.Text = ((int)time).ToString() + " сек";
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
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
