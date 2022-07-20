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

            //GreetCountries(varIn, varOut);
            Moto moto = new Moto("ducati","x5","cuatrimoto",450);
            moto.Frenar();
            moto.HacerWheelie();
        }
        static public void GreetCountries(string inputFile, string outputFile)
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



    }
}
