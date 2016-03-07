using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_Software
{
    class SimulationModeClass
    {
        private static int max_Weight_E1 = 1500;
        private static int max_Weight_E2 = 3500;
        private static int person_weight = 150;
        private static int max_Trips = 250;
        private static int item_weight = 500;
            int items_E2;
            int persons_E1;
            int persons_E2;
            int trips_E1;
            int trips_E2;
            int tripweight;
            int tripweight2;
        // Calculate random figures
        public void number_Generator(int days)
        {
           
            // Calculates random numbers for person weight
            for (int i = 0; i <= days; i++)
            {
                Random random = new Random();
                persons_E1 = random.Next(1, 21);
                persons_E2 = random.Next(1, 21);

                trips_E1 = random.Next(1, 301);
                trips_E2 = random.Next(1, 301);

                items_E2 = random.Next(1, 300);
                bool _alarm = false;
                Test_Calculate(trips_E1, persons_E1, ref _alarm);
                Test_Calculate(trips_E2, persons_E2, items_E2, ref _alarm);

                if (_alarm == true)
                {
                    Elevator_System frm = new Elevator_System();
                    //E1 
                    tripweight = Test_Calculate(trips_E1, persons_E1, ref _alarm);


                    frm._textBox3 = Value3;
                    frm._textBox = Value1;
                    frm._textBox2 = Value2;
                   
                    //E2
                    tripweight2 = Test_Calculate(trips_E2, persons_E2, items_E2, ref _alarm);

                    frm._textBox6 = Value6;
                    frm._textBox4 = Value4;
                    frm._textBox5 = Value5;
                    frm._textBox7 = Value7;

                    frm.Show();
                }
            }
        }

        // Calculate the weight of Elevator 1
        public int Test_Calculate(int trips, int passengers, ref bool _alarm)
        {

            // Calculates the total weight of the passengers
            int Max_Passenger_Weight = person_weight * passengers;

            // Calculates the total weight for each trip
            // Dvividing the total passenger weight by the trips
            int trip_weight = Max_Passenger_Weight / trips;

            // Alarm for E1
            _alarm = Alarm_E1(trip_weight, trips);

            return trip_weight;
        }

        // Calculate the weight of Elevator 2
        public int Test_Calculate(int trips, int passengers, int items, ref bool _alarm)
        {
            // Calculates the total weight of the passengers
            int Max_Passenger_Weight = person_weight * passengers;

            // Calculates the total weight of the items
            int Max_Item_Weight = items * item_weight;

            // Calculates the total weight for each trip
            // Dvividing the total passenger weight by the trips
            int trip_weight = (Max_Passenger_Weight + Max_Item_Weight) / trips;

            // Alarm for E2
            TestingModeClass Alarm = new TestingModeClass();
            _alarm = Alarm_E1(trip_weight, trips);

            return trip_weight;
        }

        // Calls an Alarm for E1

        public bool Alarm_E1(int A, int B)
        {


            if (A > max_Weight_E1)
            {

                MessageBox.Show("OverWeight", A.ToString());

                return true;


            }


            if (B > max_Trips)
            {

                MessageBox.Show("Maximum Trips Exceeded", B.ToString());

                return true;
            }
            return false;
        }
        //Trips E1
        public string Value1
        {
            get { return trips_E1.ToString(); }

        }
        //Passengers E1
        public string Value2
        {
            get { return persons_E1.ToString(); }

        }
        //Trip Weight E1
        public string Value3
        {
            get { return tripweight.ToString(); }

        }
        //Trips E2
        public string Value4
        {
            get { return trips_E2.ToString(); }

        }
        //Passengers E2
        public string Value5
        {
            get { return persons_E2.ToString(); }

        }
        //Trip Weight E2
        public string Value6
        {
            get { return tripweight2.ToString(); }

        }
        // Items E2
        public string Value7
        {
            get { return items_E2.ToString(); }

        }

    }
}
