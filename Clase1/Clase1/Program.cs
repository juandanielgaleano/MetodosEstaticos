using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {

                        
            int numero;
            string auxiliar;
            int max=0;
            int min=0;
            double cuadrado;
            double cubo;
            for (int contador=0 ; contador < 5; contador++)
            {
                Console.WriteLine("Ingrese un numero");

                auxiliar=Console.ReadLine();

                while (!int.TryParse(auxiliar, out numero))
                {
                    Console.WriteLine("Ingrese un numero");

                    auxiliar = Console.ReadLine();
                }
                    
                

                if (contador == 0)
                {
                    min = numero;
                    max = numero;
                }
                else
                {
                    if (numero > max)
                    {
                        max = numero;
                    }
                    if (numero < min)
                    {
                        min = numero;
                    }
                }
            }


            cuadrado=Math.Pow(min, 2);
            cubo = Math.Pow(max, 3);

            

            Console.WriteLine("El numero maximo es "+max);

            Console.WriteLine("El numero minimo es "+min);

            Console.WriteLine("El cuadrado del minimo es "+ cuadrado);

            Console.WriteLine("El cubo del maximo es " + cubo);

            Console.Read();

        }
    }
}
