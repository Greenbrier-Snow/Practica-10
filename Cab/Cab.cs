using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculo;

namespace Cabina
{
    
    public class Cab : Vehicle
    {
        String voucher;

        public Cab() { 
            
        }

        public Cab(double farePerKM, int distance, String voucher, int vehicleNumber):base(farePerKM,distance,vehicleNumber)
        {
            this.voucher = voucher;
            this.vehicleId = "C" +vehicleNumber;
        }

        public double CalculateTotalFare()
        {
            double tarifa = base.CalculateTotalFare();

            if(voucher!=null)
            {
                tarifa = tarifa - 50;
            }
            return tarifa*1.05;
        }

    }
}
