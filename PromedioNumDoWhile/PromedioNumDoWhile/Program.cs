using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNumDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que solicite la carga de números por teclado, obtener su promedio. 
             * Finalizar la carga de valores cuando se cargue el valor 0.*/

            int n, acu = 0,cont=0;
            do
            {
                Console.WriteLine("Digite numeros");
                n = int.Parse(Console.ReadLine());
                acu = acu + n;
                if(n!=0)
                cont++;
            } while (n != 0);

            Console.WriteLine("Se finalizo la carga, el promedio del valor es :" + acu/cont);

            Console.ReadKey();
        }
    }
}
