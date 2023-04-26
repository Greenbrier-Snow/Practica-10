using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculo;

namespace Autobus
{
    public class Bus : Vehicle
    {
        public Bus() { 
            
        }
        public Bus(double farePerKM, int distance, int vehicleNumber):base(farePerKM, distance, vehicleNumber){
            
            this.vehicleId = "B" + this.vehicleNumber;
        }
        public double CalculateTotalFare() { 

            double tarifa = base.CalculateTotalFare();

            if(tarifa > 1000) { 
                return tarifa*1.02;
            }else
                return tarifa; 
        }

    }
}
