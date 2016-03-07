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
    public partial class TestingMode : Form
    {
        Thread th;
        public TestingMode()
        {
            InitializeComponent();
        }

        int tripweight;
        private void button_Run_Test_Click(object sender, EventArgs e)
        {
            Elevator_System frm = new Elevator_System();
            // Elevator 1 test mode
            if (textBox_Passengers_E1.Text.Trim().Length != 0 && textBox_Trips_E1.Text.Trim().Length != 0)
            {
                int data_Passenger_E1 = Int32.Parse(textBox_Passengers_E1.Text);
                int data_Tips_E1 = Int32.Parse(textBox_Trips_E1.Text);


                TestingModeClass test = new TestingModeClass();


                tripweight = test.Test_Calculate(data_Tips_E1, data_Passenger_E1);
                

                frm._textBox3 = Value3; 
                frm._textBox = Value1;
                frm._textBox2 = Value2;
                


            }
            else MessageBox.Show("Please enter a number into the empty Text Box for Elevator 1");

            //Elevator 2 test mode
            if (textBox_Passengers_E2.Text.Trim().Length != 0 && textBox_Trips_E2.Text.Trim().Length != 0 &&
                textBox_Items_Sim_E2.Text.Trim().Length != 0)
            {
                int data_Passenger_E2 = Int32.Parse(textBox_Passengers_E2.Text);
                int data_Tips_E2 = Int32.Parse(textBox_Trips_E2.Text);
                int data_Item_E2 = Int32.Parse(textBox_Items_Sim_E2.Text);

                TestingModeClass test = new TestingModeClass();

                tripweight = test.Test_Calculate(data_Tips_E2, data_Passenger_E2, data_Item_E2);

                frm._textBox6 = Value6;
                frm._textBox4 = Value4;
                frm._textBox5 = Value5;
                frm._textBox7 = Value7;
            }

            else MessageBox.Show("Please enter a number into the empty Text Box for Elevator 2");
            frm.Show();



        }
        //Trips E1
        public string Value1
        {
            get { return textBox_Trips_E1.Text; }

        }
        //Passengers E1
        public string Value2
        {
            get { return textBox_Passengers_E1.Text; }

        }
        //Trip Weight E1
        public string Value3
        {
            get { return tripweight.ToString(); }

        }
        //Trips E2
        public string Value4
        {
            get { return textBox_Trips_E2.Text; }

        }
        //Passengers E2
        public string Value5
        {
            get { return textBox_Passengers_E2.Text; }

        }
        //Trip Weight E2
        public string Value6
        {
            get { return tripweight.ToString(); }

        }
        // Items E2
        public string Value7
        {
            get { return textBox_Items_Sim_E2.Text; }

        }
       


    }
}

