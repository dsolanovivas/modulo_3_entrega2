using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosHasta9999DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 
             * (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el valor acumulado e informar 
             * si dicho valor es cero, mayor a cero o menor a cero.*/

            int n, acu=0;
          
            do{
              Console.WriteLine("Digite numero");
              n = int.Parse(Console.ReadLine());

              if (n != 9999)
                  acu = acu + n;

            }while(n!=9999);

            Console.WriteLine("Se finalizo la carga, el valor es :"+acu);
            if(acu==0)
                Console.WriteLine("el valor es igual a cero");
            if(acu>0)
                Console.WriteLine("el valor es mayor a cero");
            if(acu<0)
                Console.WriteLine("el valor es menor a cero");

            Console.ReadKey();
        }
    }
}
