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

        private void massForm_Load(object sender, EventArgs e)
        {
            
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

        int g = 10; //ускорение свободного падения (округленное)
        double KGtoH = 9.8; // масса в ньютон, умножаем силу (в кг) на 9.8 и получается сила в ньютонах; округленное)
        private void tmr_emulation_Tick(object sender, EventArgs e)
        {
            double a = 10; // интересно, почему? из формулы силы (ищите в программе) получается что a = v/t. в моем случае, А ИМЕННО В КАЖДОМ, это всегда давало десять. Попробуйте сами :)
            double mass = (double)stregthNum.Value / a;

                label3.Text = label3.Text + " " + mass.ToString() + " кг";
                tmr_emulation.Enabled = false;
            
        }
    }
}
