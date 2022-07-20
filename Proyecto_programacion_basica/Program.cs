using System.IO;
using System;
using System.Collections.Generic;
using ClasesVehiculos;

namespace Proyecto_programacion_basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateFormat = DateTime.Now.ToString("yyyy-MMMM-dd");
            string fileName = $"Countries {dateFormat}";
            string varIn = "C:\\Users\\a875026\\source\\repos\\Proyecto_programacion_basica\\Proyecto_programacion_basica\\countries.txt";
            string varOut = $"C:\\Users\\a875026\\source\\repos\\Proyecto_programacion_basica\\Proyecto_programacion_basica\\{fileName}.txt";

            
            //1.0 Conceptos generales
            GreetCountries(varIn, varOut);

            //2.0 Programacion orientada a objetos
            Moto moto = new Moto("ducati","x5","cuatrimoto",450);
            moto.Frenar();
            moto.HacerWheelie();

            //3.2 Prueba metodo Fail();
            Fail fallo = new Fail(1,0);
            fallo.ArrojaExcepcion();
        }
        static public void GreetCountries(string inputFile, string outputFile)
        {
            try
            {
            //Leemos el archivo countries.txt y guardamos cada linea en el array fileReader
             string[] fileReader = File.ReadAllLines(inputFile);
            

            //Creamos una lista vacia donde se guardan las filas de texto generadas
            List<string> contryList = new List<string>();

            //Iteramos por cada elemento del Array fileReader, agregando cada linea editada a la lista contryList
            foreach(string f in fileReader)
            {
                var placeHolder = $"Saludos hasta {f}!";
                contryList.Add(placeHolder);
                
            }
            //Finalmente escribimos todas las lineas editadas en el archivo output
            File.WriteAllLines(outputFile, contryList);
            Console.WriteLine("Done!");
            }
            catch(Exception e)
            {
                if (e is FileNotFoundException)
                {
                    Console.WriteLine("El programa no corre porque no encuentra el arhcivo en la ruta especificada");
                    return;
                }
                Console.WriteLine($"El programa no corre por un error general: {e.Message.ToString()}");
            }
        }
    }
}
