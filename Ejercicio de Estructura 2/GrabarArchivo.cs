using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Estructura_2
{
    internal class GrabarArchivo
    {
        public static void Iniciar()
        {
            using StreamWriter writer = File.CreateText("Autos.txt");

            foreach (Auto auto in Auto.Todos)
            {
                string linea = auto.Marca + "|"
                    + auto.Modelo + "|"
                    + auto.Año + "|"
                    + auto.Precio;
                writer.WriteLine(linea);
            }
            Console.WriteLine("Archivo guardado exitosamente");
        }
    }
}
