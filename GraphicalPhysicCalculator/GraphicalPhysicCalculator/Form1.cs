using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace GraphicalPhysicCalculator
{
    public partial class Form1 : System.Windows.Forms.Form
    { 
        bool isElemationStarted = false;

        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isElemationStarted = true;
            Graph.Maximum = (int)Distance.Value;
            tmr_emulation.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            tmr_emulation.Enabled = false;
            Graph.Value = 0;
        }

        private void tmr_emulation_Tick(object sender, EventArgs e)
        {
            int speed = (int)Speed.Value;
            if (Graph.Value + speed > Graph.Maximum)
            {
                tmr_emulation.Enabled = false;
                MessageBox.Show("Путь пройден!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Graph.Value = 0;
                return;
            }
            Graph.Value += speed;
            int remaining = (int)Distance.Value - Graph.Value;
            remainingTime.Text = remaining / speed + " сек";
            int magic = (int)-(remaining / speed - (Distance.Value / speed));
            total.Text = magic + " сек";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            tmr_emulation.Enabled = false;
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
