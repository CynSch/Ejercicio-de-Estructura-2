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

                //Año
                int año = 0;
                while (true)
                {
                    Console.WriteLine("Ingrese el año del auto");
                    string ingreso = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingreso))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                        continue;
                    }
                    if (!int.TryParse(ingreso, out int añoingresado))
                    {
                        Console.WriteLine("Ingrese un valor numerico");
                        continue;
                    }
                    if (añoingresado < 2000 || añoingresado > 2021)
                    {
                        Console.WriteLine("El año debe ser entre 2000 y 2021");
                        continue;
                    }
                    año = añoingresado;
                    break;
                }

                    //Precio
                    decimal precio = 0;
                    while (true)
                    {
                        Console.WriteLine("Ingrese el precio del auto");
                        string ingreso = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(ingreso))
                        {
                            Console.WriteLine("Debe ingresar un valor");
                            continue;
                        }    
                        if(!decimal.TryParse(ingreso, out decimal precioingresado))
                        {
                            Console.WriteLine("Ingrese un valor decimal");
                            continue;
                        }
                        if(precioingresado < 0)
                        {
                            Console.WriteLine("El precio debe ser mayor a 0");
                            continue;
                        }
                        precio = precioingresado;
                        break;
                    }
            }
        }
    }
}
