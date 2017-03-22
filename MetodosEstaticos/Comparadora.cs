using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Comparadora
    {
        /// <summary> Devuelve el mayor numero ingresado
        ///
        /// 
        /// </summary>
        /// <param name="num1">El primer entero</param>
        /// <param name="num2">El segundo entero</param>
        /// <returns>El Mayor</returns>
        public static int retornarMayor(int num1, int num2)    
    
         {
                int retorno=0;

                if (num1 > num2)
                    retorno = num1;
                else
                    retorno = num2;

                return retorno;

         }
        /// <summary> Retorna el valor del medio
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        public static void MostrarEldelMedio(int num1, int num2, int num3)    

        {
            
        }
    }
}
