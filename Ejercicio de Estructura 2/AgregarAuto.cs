using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Estructura_2
{
    internal class AgregarAuto
    {
        public static void Iniciar()
        {
            while(true)
            {
                //Marca|Modelo|Año|Precio

                //Marca
                string marca = "";
                while(true)
                {
                    Console.WriteLine("Ingrese la marca del auto");
                    marca = Console.ReadLine();

                    if(string.IsNullOrWhiteSpace(marca))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                        continue;
                    }

                    if(marca.Length > 30)
                    {
                        Console.WriteLine("Debe utilizar como máximo 30 caracteres");
                        continue;
                    }
                    break;
                }

                //Modelo
                string modelo = "";
                while(true)
                {
                    Console.WriteLine("Ingrese el modelo del auto");
                    modelo = Console.ReadLine();

                    if(string.IsNullOrWhiteSpace(modelo))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                        continue;
                    }

                    if(marca.Length > 30)
                    {
                        Console.WriteLine("Debe utilizar como máximo 30 caracteres");
                        continue;

                    }
                    break;
                }
            }
        }
    }
}
