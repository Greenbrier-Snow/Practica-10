using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Vehicle
    {
        public int distance;
        public double farePerKM;
        protected string vehicleId;
        protected int vehicleNumber;
        public Vehicle()
        {

        }
        public Vehicle(double farePerKM, int distance, int vehicleNumber)
        {
            this.distance = distance;
            this.farePerKM = farePerKM;
            this.vehicleNumber = vehicleNumber;
        }
        public double CalculateTotalFare() {
            return distance*farePerKM;
        }

        

    }
}
