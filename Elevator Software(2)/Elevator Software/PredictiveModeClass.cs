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
    class PredictiveModeClass
    {
        private static int max_Weight_E1 = 1500;
        private static int max_Weight_E2 = 3500;
        private static int max_Trips = 750;
        private static int maintenance_E1 = 250;
        private static int maintenance_E2 = 500;
        private static int person_weight = 150;
        private static int item_weight = 500;

        private int personE1 = 0;
        private int personE2 = 0;
        private int weightE1 = 0;
        private int weightE2 = 0;
        private int tripsE1 = 0;
        private int tripsE2 = 0;
        private int itemsE2 = 0;
        private int j = 1;
        private int k = 1;
        

        public void Print()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("WriteLines2.txt", true))
            {

                file.WriteLine("Day: " + j + "\n");
                file.WriteLine("Elevator 1: " + "  People: " + personE1 + " " + "  Trips: " + tripsE1 + " " + "  Weight: " + weightE1 + " " + "\n\n");
                file.WriteLine("Day: " + k + "\n");
                file.WriteLine("Elevator 2: " + "  People: " + personE2 + " " + "  Trips: " + tripsE2 + " " + "  Items:  " + itemsE2 + "  Weight: " + weightE2 + "\n");

                file.WriteLine("\n");


            }
        }
        public int FailureCalculator(int trips, int people)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("WriteLines2.txt", true))
            {
                personE1 = people;
                tripsE1 = trips;


                // Calculates the total weight of the passengers
                int Max_Passenger_Weight = person_weight * people;

                // Calculates the total weight for each trip
                // Dvividing the total passenger weight by the trips
                int trip_weight = Max_Passenger_Weight / trips;

                int i = 0;
                int Failure = trip_weight;

                if (trips < max_Trips)
                {
                    // Calculate failure
                    while (Failure <= max_Weight_E1)
                    {
                        Failure = Failure + trip_weight;

                        file.WriteLine("Day: " + j + "\n");
                        file.WriteLine("Elevator 1: " + "  People: " + personE1 + " " + "  Trips: " + tripsE1 + " " + "  Weight: " + weightE1 + " " + "\n\n");
                        file.WriteLine("Day: " + k + "\n");
                        file.WriteLine("Elevator 2: " + "  People: " + personE2 + " " + "  Trips: " + tripsE2 + " " + "  Items:  " + itemsE2 + "  Weight: " + weightE2 + "\n");

                        file.WriteLine("\n");

                        i++;
                        j++;
                    }
                }
                weightE1 = Failure;
                return i;
            }  
            
        }
        public int FailureCalculator(int trips, int people, int items)
        {
            personE1 = people;
            tripsE1 = trips;
            itemsE2 = items;
            // Calculates the total weight of the passengers
            int Max_Passenger_Weight = person_weight * people;

            // Calculates the total weight of the items
            int Max_Item_Weight = items * item_weight;

            // Calculates the total weight for each trip
            // Dvividing the total passenger weight by the trips
            int trip_weight = (Max_Passenger_Weight + Max_Item_Weight) / trips;

            int i = 0;
            int Failure =trip_weight;
            
            if (trips < max_Trips)
            {
                // Calculate failure
                while (Failure <= max_Weight_E2)
                {
                    Failure = Failure + trip_weight;
                    i++;
                    k++;
                }
            }  
            weightE2 = Failure;
            return i;
          
        }



    }

}
