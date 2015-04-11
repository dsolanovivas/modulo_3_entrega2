using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachVectorMayor100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un vector de n elementos de tipo entero (n se ingresa por teclado) Mostrar cuantos 
             * elementos son superiores a 100 (emplear el foreach para recorrer el vector).*/

            int n,i, cont=0,valor;
            Console.WriteLine("Digite la cantidad de numeros");
            n = int.Parse(Console.ReadLine());
            int[] vector= new int[n];
            for(i=0;i<n;i++)
            {
             Console.WriteLine("Digite el dato");
             valor = int.Parse(Console.ReadLine());
             vector[i]=valor;
            }
            foreach (int m in vector)
            {
                if (m > 100)
                    cont++;

            }
            Console.WriteLine("La cantidad de numero mayor a 100 son :"+cont);
            Console.ReadKey();
        }
    }
}
