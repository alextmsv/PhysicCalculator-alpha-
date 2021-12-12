using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace GraphicalPhysicCalculator
{
    public partial class massForm : Form
    {
        public massForm()
        {
            InitializeComponent();
            tmr_emulation.Enabled = false;
        }

        private void strengthCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void massForm_Load(object sender, EventArgs e)
        {
            stregthNum.Maximum = 10000;
            aNum.Maximum = 10000;
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {

        }

        private void stregthNum_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            tmr_emulation.Enabled = true;
            label3.Text = "m (масса) =";
        }

        private void tmr_emulation_Tick(object sender, EventArgs e)
        {
            
            double mass = (int)stregthNum.Value / (int)aNum.Value;

                label3.Text = label3.Text + " " + mass.ToString() + " кг";
                tmr_emulation.Enabled = false;
            
        }
    }
}
