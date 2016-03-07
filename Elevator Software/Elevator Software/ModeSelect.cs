using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Elevator_Software
{
    public partial class ModeSelect : Form
    {
        Thread th;
        public ModeSelect()
        {
            InitializeComponent();
        }

        private void button_TestingMode_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
           
        }
        private void opennewform(object obj)
        {
            Application.Run(new TestingMode());
        }


        private void button_SimulationMode_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        private void opennewform2(object obj)
        {
            Application.Run(new SimulationMode());
        }



        private void button3_PredicitveMode_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform3(object obj)
        {
            Application.Run(new SimulationMode());
        }

           

    }
}
