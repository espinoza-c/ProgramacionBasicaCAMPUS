using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesVehiculos
{
    sealed public class Moto : Vehiculo
    {
        private string TypeOfBike { get; set; }
        private int CubicCentimeters { get; set; }

        public Moto(string marca, string modelo, string typeOfBike, int cubicCentimeters) : base(marca, modelo)  
        {
            Marca = marca;
            Modelo = modelo;
            TypeOfBike = typeOfBike;
            CubicCentimeters = cubicCentimeters;

        }

        public void Frenar()
        {
            Console.WriteLine($"La moto {Marca} modelo {Modelo} de tipo {TypeOfBike} frena, tardo por sus {CubicCentimeters} cc.");

        }
        public void HacerWheelie()
        {
            Console.WriteLine($"La moto {Marca} modelo {Modelo} de tipo {TypeOfBike} hace un truco, es fac por sus {CubicCentimeters} cc.");
        }


    }
}
