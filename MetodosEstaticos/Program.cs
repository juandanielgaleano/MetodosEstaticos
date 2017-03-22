using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor;
            string dato;

            Sello.mensaje="nuevo Mensaje";
            dato = Sello.imprimir();

            

            Console.WriteLine(dato);

            Sello.Color = ConsoleColor.Red;

            mayor=Comparadora.retornarMayor(10, 5);

            Sello.imprimirColor;


        }
    }
}
