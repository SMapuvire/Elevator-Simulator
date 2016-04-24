using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Elevator_Software
{
    class TestingModeClass
    {
        private static int max_Weight_E1 = 1500;
        private static int max_Weight_E2 = 3500;
        private static int person_weight = 150;
        private static int max_Trips = 750;
        private static int item_weight = 500;
        private static int maintenance_E1 = 250;
        private static int maintenance_E2 = 500;
    

     
        // Calculate the weight of Elevator 1
        public int Test_Calculate(int trips, int passengers) 
        {
            // Calculates the total weight of the passengers
            int Max_Passenger_Weight = person_weight * passengers;

            // Calculates the total weight for each trip
            // Dvividing the total passenger weight by the trips
            int trip_weight = Max_Passenger_Weight / trips;

            // Alarm for E1
            TestingModeClass Alarm = new TestingModeClass();
            Alarm.Alarm_E1(trip_weight, trips);

            return trip_weight;
         
        }
        // Calculate the weight of Elevator 2
        public int Test_Calculate(int trips, int passengers, int items)
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
            Alarm.Alarm_E2(trip_weight, trips);

            return trip_weight;

        }

        // Calls an Alarm for E1
        public bool Alarm_E1(int A, int B)
        {
            if (A > max_Weight_E1)
            {
                MessageBox.Show("OverWeight Alarm Elevator 1", A.ToString());
                return true;
            }
            if (B > max_Trips)
            {
                MessageBox.Show("Maximum Trips Exceeded Alarm Elevator 1", B.ToString());
                return true;
            }
            if (B > maintenance_E1 && B < max_Trips)
            {
                MessageBox.Show("Maintenance Alarm Elevator 1", B.ToString());
                return true;
            }
            return false;
        }

        // Calls an Alarm for E2
        public bool Alarm_E2(int A, int B)
        {
            if (A > max_Weight_E2)
            {
                MessageBox.Show("OverWeight Alarm Elevator 2", A.ToString());
                return true;
            }
            if (B > max_Trips)
            {
                MessageBox.Show("Maximum Trips Exceeded Alarm Elevator 2", B.ToString());
                return true;
            }
            if (B > maintenance_E2 && B < max_Trips)
            {
                MessageBox.Show("Maintenance Alarm Elevator 2", B.ToString());
                return true;
            }
            return false;
        }

        // Loop for floor select
        public int floorSelect(int trips)
        {
            int floor = 0;

            for (int i = 0; i < trips; i++)
            {
                floor = trips & 5;
            }

                return floor;

        }
 
    }
}
