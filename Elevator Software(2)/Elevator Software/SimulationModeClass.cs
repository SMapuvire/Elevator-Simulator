using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Elevator_Software
{
    class SimulationModeClass
    {
        private static int max_Weight_E1 = 1500;
        private static int max_Weight_E2 = 3500;
        private static int person_weight = 150;
        private static int max_Trips = 750;
        private static int item_weight = 500;
        private static int maintenance_E1 = 250;
        private static int maintenance_E2 = 500;
       

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
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("WriteLines.txt", true))
            {
                // Calculates random numbers for persons, weight and items
                int i;
                for ( i = 1; i <= days; i++)
                {
                    int temp_E1;
                    int temp_E2;
                    int temp2_E2;

                    Random random = new Random();
                    //Max persons per day 200
                    persons_E1 = StaticRandom.Instance.Next(1, 201);
                    trips_E1 = StaticRandom.Instance.Next(1, persons_E1);

                    //Max Persons per day 300 and Max items per day 50
                    persons_E2 = StaticRandom2.Instance.Next(1, 301);
                    items_E2 = StaticRandom.Instance.Next(1, 51);

                    temp2_E2 = persons_E2 + items_E2;
                    trips_E2 = StaticRandom2.Instance.Next(1, temp2_E2);

                    bool _alarm = false;

                    Test_Calculate(trips_E1, persons_E1, ref _alarm);
                    temp_E1 = Test_Calculate(trips_E1, persons_E1, ref _alarm);

                    Test_Calculate(trips_E2, persons_E2, items_E2, ref _alarm);
                    temp_E2 = Test_Calculate(trips_E2, persons_E2, items_E2, ref _alarm); 

                    //writes each run to a text file
                    file.WriteLine("Day: " + i + "\n");
                    file.WriteLine("Elevator 1: " + "  People: " + persons_E1 + " " + "  Trips: " + trips_E1 + " " + "  Weight: " + temp_E1  + " " + "\n");
                    file.WriteLine("Elevator 2: " + "  People: " + persons_E1 + " " + "  Trips: " + trips_E1 + " " + "  Items:  " + items_E2 + "  Weight: " + temp_E2 + "\n");
                    file.WriteLine("\n");

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
        }
        // Generates Random number without duplicate problem E1
        public static class StaticRandom
        {
            private static int seed;

            private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
                (() => new Random(Interlocked.Increment(ref seed)));

            static StaticRandom()
            {
                seed = Environment.TickCount;
            }

            public static Random Instance { get { return threadLocal.Value; } }
        }

        // Generates Random number without duplicate problem E2
        public static class StaticRandom2
        {
            private static int seed;

            private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
                (() => new Random(Interlocked.Increment(ref seed)));

            static StaticRandom2()
            {
                seed = Environment.TickCount;
            }

            public static Random Instance { get { return threadLocal.Value; } }
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
            _alarm = Alarm_E2(trip_weight, trips);

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
            if (B > maintenance_E1)
            {
                MessageBox.Show("Maximum Trips Exceeded", B.ToString());
                return true;
            }
            return false;
        }

        // Calls an Alarm for E2
        public bool Alarm_E2(int A, int B)
        {
            if (A > max_Weight_E2)
            {
                MessageBox.Show("OverWeight", A.ToString());
                return true;
            }
            if (B > max_Trips)
            {
                MessageBox.Show("Maximum Trips Exceeded", B.ToString());
                return true;
            }
            if(B> maintenance_E2)
            {
                MessageBox.Show("Maximum Trips Exceeded", B.ToString());
                return true;
            }
            return false;
        }

        // Loop for floor select
        public int floorSelect(int trips)
        {
            int floor = 0;

            for (int i = 0; i < trips; i++)
                floor = trips & 5;
            
            return floor; 
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
