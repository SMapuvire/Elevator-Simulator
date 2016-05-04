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
    public partial class PredictiveMode : Form
    {
        public PredictiveMode()
        {
            InitializeComponent();
        }

        int ElevatorFailureDays;
        int ElevatorFailureDays2;

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_People_E1.Text.Trim().Length != 0 && textBox_Trips_E1.Text.Trim().Length != 0)
            {
                int data_Passenger_E1 = Int32.Parse(textBox_People_E1.Text);
                int data_Trips_E1 = Int32.Parse(textBox_Trips_E1.Text);
                PredictiveModeClass predict = new PredictiveModeClass();


                    ElevatorFailureDays = predict.FailureCalculator(data_Trips_E1, data_Passenger_E1);
                   // predict.Print();
            }
            else if (textBox_People_E1.Text.Trim().Length == 0 && textBox_Trips_E1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a number into the empty Text Box for Elevator 1");
    
            }


            if (textBox_People_E2.Text.Trim().Length != 0 && textBox_Trips_E2.Text.Trim().Length != 0 &&
                textBox_Items_E2.Text.Trim().Length != 0)
            {
                int data_Passenger_E2 = Int32.Parse(textBox_People_E2.Text);
                int data_Trips_E2 = Int32.Parse(textBox_Trips_E2.Text);
                int data_Items_E2 = Int32.Parse(textBox_Items_E2.Text);
                PredictiveModeClass predict = new PredictiveModeClass();

                ElevatorFailureDays2 = predict.FailureCalculator(data_Trips_E2, data_Passenger_E2, data_Items_E2);
               // predict.Print();
            }
            else if (textBox_People_E2.Text.Trim().Length == 0 && textBox_Trips_E2.Text.Trim().Length == 0 &&
                     textBox_Items_E2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a number into the empty Text Box for Elevator 2");
            }


            
           
            MessageBox.Show(ElevatorFailureDays.ToString());
            MessageBox.Show(ElevatorFailureDays2.ToString());
        }

       
    }
}
