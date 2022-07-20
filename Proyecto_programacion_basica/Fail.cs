using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_programacion_basica
{
    public class Fail
    {
        protected decimal NumeroUno { get; set; }
        protected decimal NumeroDos { get; set; }

        public Fail(decimal numeroUno, decimal numeroDos)
        {
            NumeroUno = numeroUno;
            NumeroDos = numeroDos;
        }
    
        public void ArrojaExcepcion()
        {
            try
            {
                decimal result = NumeroUno / NumeroDos;
                Console.WriteLine(result.ToString());
            }
            catch(Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
