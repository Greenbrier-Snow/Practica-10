using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autobus;
using Cabina;
using Vehiculo;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle carrito = new Vehicle(20,100,7878);
            Bus autobus = new Bus(10,300,0303);
            Cab cabina = new Cab(15,250,null,4545);

            Console.WriteLine(carrito.CalculateTotalFare());
            Console.WriteLine(autobus.CalculateTotalFare());
            Console.WriteLine(cabina.CalculateTotalFare());
        }
    }
}
