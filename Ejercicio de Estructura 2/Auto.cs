using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Estructura_2
{
    internal class Auto
    {
        public static List<Auto> Todos = new List<Auto>();
        public string Marca; //max 30 caracteres
        public string Modelo; //max 30 caracteres
        public int Año; // 4 cifras entre 2000 y 2021
        public decimal Precio; //mayor a 0
    }
}
