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
    public partial class Elevator_System : Form
    {
        public Elevator_System()
        {
            InitializeComponent();
        }
        
        //Opens the log
        private void button4_Click(object sender, EventArgs e)
        {
            Log frm = new Log();
            frm.Show();
        }
        
        // Passing trip value from testing mode to this form to textbox E1
        public string _textBox
        {
            set
            {
                if (Int32.Parse(value) > 250)
                    textBox_trips_E1.ForeColor = Color.Red;
                textBox_trips_E1.Text = value;

            } 
        }
        // Passing people value from testing mode to this form to textbox E1
        public string _textBox2
        {
            set
            {
                textBox_people_E1.Text = value;
            } 
        }
        // Passing weight value from testing mode to this form to textbox E1
        public string _textBox3
        {
            set
            {
                if (Int32.Parse(value) > 1500)
                    textBox_weight_E1.ForeColor = Color.Red;
                textBox_weight_E1.Text = value;
            }
        }
        // Passing trip value from testing mode to this form to textbox E1
        public string _textBox4
        {
            set
            {
                if (Int32.Parse(value) > 250)
                    textBox_trips_E2.ForeColor = Color.Red;
                textBox_trips_E2.Text = value;

            }
        }
        // Passing people value from testing mode to this form to textbox E1
        public string _textBox5
        {
            set
            {
                textBox_people_E2.Text = value;
            }
        }
        // Passing weight value from testing mode to this form to textbox E1
        public string _textBox6
        {
            set
            {
                if (Int32.Parse(value) > 3500)
                    textBox_weight_E2.ForeColor = Color.Red;
                textBox_weight_E2.Text = value;
            }
        }
        // Passing item value from testing mode to this form to textbox E2
        public string _textBox7
        {
            set
            {
                textBox_items_E2.Text = value;
            }
        }
        
        // Testing mode and the different components 
        private void testingModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Enabling correct button for field
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;

            // Visible correct label for field 
            Test_Label.Visible = true;
            Sim_Label.Visible = false;
            Pred_Label.Visible = false;

            //Pop up test run 
            TestingMode frm = new TestingMode();
            frm.Show();
        }

        private void simulationModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Enabling correct button for field
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;

            // Visible correct label for field 
            Test_Label.Visible = false;
            Sim_Label.Visible = true;
            Pred_Label.Visible = false;

            //Pop up Simulation run
            SimulationMode frm = new SimulationMode();
            frm.Show();
        }

        private void predicitiveModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Enabling correct button for field
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;

            // Visible correct label for field 
            Test_Label.Visible = false;
            Sim_Label.Visible = false;
            Pred_Label.Visible = true;

            //Pop up Predicitve run
            PredictiveMode frm = new PredictiveMode();
            frm.Show();


        }



    }
}
