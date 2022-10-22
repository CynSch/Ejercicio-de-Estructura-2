using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Estructura_2
{
    internal class ListarAutos
    {
        public static void Listar()
        {
            foreach (Auto auto in Auto.Todos)
            {
                Console.WriteLine("Marca: " + auto.Marca
                    + "\nModelo: " + auto.Modelo
                    + "\nAño: " + auto.Año
                    + "\nPrecio: " + auto.Precio);
            }
        }
    }
}
