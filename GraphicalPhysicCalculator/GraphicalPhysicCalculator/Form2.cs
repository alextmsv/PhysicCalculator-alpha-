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
    public partial class distanceForm : Form
    {
        bool IsEmulationStarted = false;
        public distanceForm()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Graph_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            IsEmulationStarted = true;
            tmr_emulation.Enabled = true;
        }

        private void tmr_emulation_Tick(object sender, EventArgs e)
        {
            Graph.Maximum = (int)(speed.Value * time.Value);
            int Speed = (int)speed.Value;
            if (Graph.Value + Speed > Graph.Maximum)
            {
                tmr_emulation.Enabled = false;
                MessageBox.Show("Путь пройден!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Graph.Value = 0;
                return;
            }
            Graph.Value += Speed;
            int totalTime = Graph.Value;
            totalDst.Text = (totalTime * Speed).ToString();
            int totalDstInt = Convert.ToInt32(totalDst.Text);
            remainingDst.Text = (speed.Value*time.Value - totalDstInt).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void speed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void totalDst_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            tmr_emulation.Enabled = false;
        }
    }
}
