using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Estructura_2
{
    internal class LeerArchivo
    {
        public static void Iniciar()
        {
            Console.WriteLine("Leyendo información guardada previamente...");

            using StreamReader reader = new StreamReader("Autos.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                //Marca|Modelo|Año|Precio

                string [] datos = linea.Split('|');

                Auto auto = new Auto();
                auto.Marca = datos[0];
                auto.Modelo = datos[1];
                auto.Año = int.Parse(datos[2]);
                auto.Precio = decimal.Parse(datos[3]);

                Auto.Todos.Add(auto);
            }
        }
    }
}
