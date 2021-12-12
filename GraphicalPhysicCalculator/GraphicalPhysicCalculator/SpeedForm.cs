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
    public partial class SpeedForm : Form
    {
        bool timerEmulation = false;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public SpeedForm()
        {
            InitializeComponent();
        }

        private void SpeedForm_Load(object sender, EventArgs e)
        {

        }

        private void tmr_emulation_Tick(object sender, EventArgs e)
        {
            Graph.Maximum = (int)distance.Value;
            int speed = (int)(distance.Value / time.Value);
            if (Graph.Value + speed > Graph.Maximum)
            {
                tmr_emulation.Enabled = false;
                MessageBox.Show("Путь пройден!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Graph.Value = 0;
                return;
            }
            Graph.Value += speed;
            int totalTime = Graph.Value;
            int totalDst = totalTime * speed;
            currentSpd.Text = (totalDst/totalTime).ToString();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timerEmulation = true;
            tmr_emulation.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            tmr_emulation.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
