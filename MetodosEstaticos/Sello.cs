using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Sello
    {
        public static string mensaje;

        public static void imprimirColor()
        {
            Console.ForegroundColor;

            Console.WriteLine();
        }
        
        /// <summary> colocar asteriscos a mensaje
        /// 
        /// </summary>
        public static void borrarMensaje()
        {
            Sello.mensaje = " ";
        }
        public static ConsoleColor Color;
      
        public static string imprimir()
        {      
            return "algo";            
        }
        
    }
}
