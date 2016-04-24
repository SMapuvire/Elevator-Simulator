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
        
        // Passing trip value from testing mode to this form to Maintenance TextBox and Trips TextBox E1
        public string _textBox
        {
            set
            {
                textBox_trips_E1.Text = value;
                if (Int32.Parse(value) > 750)
                {
                    textBox_Maintenance_E1.ForeColor = Color.Red;
                    textBox_Maintenance_E1.Text = value;
                }
                else if (Int32.Parse(value) > 250)
                {
                    textBox_Maintenance_E1.ForeColor = Color.Green;
                    textBox_Maintenance_E1.Text = value;
                }

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
        // Passing trip value from testing mode to this form to Maintenance TextBox and Trips TextBox E2
        public string _textBox4
        {
            set
            {
                textBox_trips_E2.Text = value;
                if (Int32.Parse(value) > 750)
                {
                    textBox_Maintenance_E2.ForeColor = Color.Red;
                    textBox_Maintenance_E2.Text = value;
                }
                else if (Int32.Parse(value) > 250)
                {
                    textBox_Maintenance_E2.ForeColor = Color.Green;
                    textBox_Maintenance_E2.Text = value;
                }

            }
        }
        // Passing people value from testing mode to this form to textbox E2
        public string _textBox5
        {
            set
            {
                textBox_people_E2.Text = value;
            }
        }
        // Passing weight value from testing mode to this form to textbox E2
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
        //Passing floor number value for Elevator 1
        public int _pictureE1
        {
            set
            {
                if(value == 0)
                pictureBox1.Visible = true;
                if (value == 1)
                    pictureBox3.Visible = true;
                if (value == 2)
                    pictureBox5.Visible = true;
                if (value == 3)
                    pictureBox7.Visible = true;
                if (value == 4)
                    pictureBox9.Visible = true;
            }
             
            
        }
        //Passing floor number value for ELevator 2
        public int _pictureE2
        {
            set
            {
                if (value == 0)
                    pictureBox2.Visible = true;
                if (value == 1)
                    pictureBox4.Visible = true;
                if (value == 2)
                    pictureBox6.Visible = true;
                if (value == 3)
                    pictureBox8.Visible = true;
                if (value == 4)
                    pictureBox10.Visible = true;
            }


        }

        
        // Testing mode pop up window
        private void testingModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestingMode frm = new TestingMode();
            frm.Show();
            
        }
        // Simulation Mode pop up window
        private void simulationModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SimulationMode frm = new SimulationMode();
            frm.Show();
        }
        // Predictive Mode pop up window
        private void predicitiveModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PredictiveMode frm = new PredictiveMode();
            frm.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // About pop up window
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }
        // Help pop up window
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help from = new Help();
            from.Show();
        }



    }
}
