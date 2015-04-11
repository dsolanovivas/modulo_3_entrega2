using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NnumeroMayoresoIgualesa1000
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.*/
            int i, cont = 0,n;
            float num;
            Console.WriteLine("Digite la cantidad de numeros");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Digite numero");
                num = float.Parse(Console.ReadLine());
                if (num >= 1000)
                    cont++;
            }

            Console.WriteLine("La cantidad de numeros mayores o iguales de 1000 son :" + cont);
            Console.ReadKey();
        }
    }
}
