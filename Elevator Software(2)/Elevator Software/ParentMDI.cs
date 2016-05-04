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
    public partial class ParentMDI : Form
    {
        public ParentMDI()
        {
            InitializeComponent();
        }

        private void testingModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestingMode frm = new TestingMode();
            frm.MdiParent = this;
            frm.Show();
        }

        private void simulationModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimulationMode frm = new SimulationMode();
            frm.MdiParent = this;
            frm.Show();
        }

        private void predictiveOdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PredictiveMode frm = new PredictiveMode();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help frm = new Help();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.MdiParent = this;
            frm.Show();
        }

        private void simulationLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log frm = new Log();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
