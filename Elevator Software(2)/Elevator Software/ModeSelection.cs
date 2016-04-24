using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_Software
{
    public partial class ModeSelection : Form
    {
        public ModeSelection()
        {
            InitializeComponent();
        }
        //Open testing mode window
        private void button3_Click(object sender, EventArgs e)
        {
            TestingMode frm = new TestingMode();
            frm.Show();
        }
        //Open simulation mode window
        private void button2_Click(object sender, EventArgs e)
        {
            SimulationMode frm = new SimulationMode();
            frm.Show();
        }
        //Open predicitve mode window
        private void button1_Click(object sender, EventArgs e)
        {
            PredictiveMode frm = new PredictiveMode();
            frm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help from = new Help();
            from.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log frm = new Log();
            frm.Show();

        }

    }
}
