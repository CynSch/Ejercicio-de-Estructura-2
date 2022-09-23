using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Estructura_2
{
    internal class Menu
    {
        public static void Listar()
        {
            do
            {
                Console.WriteLine("1. Agregar Auto");
                Console.WriteLine("2. Grabar");
                Console.WriteLine("3. Ver lista de autos guardados");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese su opción");

                string ingreso = Console.ReadLine();

                if (!int.TryParse(ingreso, out int opcion))
                {
                    Console.WriteLine("Ingrese un numero de opción");
                    continue;
                }

                if (opcion == 1)
                {
                    AgregarAuto.Iniciar();
                }

                if (opcion == 2)
                {
                    GrabarArchivo.Iniciar();
                }

                if (opcion == 3)
                {
                    ListarAutos.Listar();
                }

                if (opcion == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese un numero del 1 al 4");
                }
            } while (true);
        }
    }
}
