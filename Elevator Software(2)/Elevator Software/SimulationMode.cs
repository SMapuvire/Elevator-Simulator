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
    public partial class SimulationMode : Form
    {
        public SimulationMode()
        {
            InitializeComponent();
        }

        private void button1_Run_Sim_Click(object sender, EventArgs e)
        {
            int days = Int32.Parse(textBox_Days_Sim.Text);

            SimulationModeClass sim = new SimulationModeClass();
            sim.number_Generator(days);
            

        }
    }
}
