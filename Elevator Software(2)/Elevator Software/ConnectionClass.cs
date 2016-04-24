using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Elevator_Software
{
    class ConnectionClass
    {
        private int Weight;
        private int Trips;
        private int Passengers;
        // Gets Values from Class to write to log databse
        public void getValues(int weight, int trips, int passengers)
        {
             Weight = weight;
             Trips = trips;
             Passengers = passengers;
        }
       
    }
}
