using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesVehiculos
{
    public abstract class Vehiculo
    {
        protected string Marca { get; set; }
        protected string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        protected void Arrancar()
        {
            Console.WriteLine("El vehiculo arranca");

        }
        protected void Acelerar()
        {
            Console.WriteLine("El vehiculo acelera");
        }
    }
}
