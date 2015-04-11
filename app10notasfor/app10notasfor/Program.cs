using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app10notasfor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cont=0, cont2=0, cont3=0;
            double nota;
            /*Escribir un programa que lea 10 notas de alumnos y nos informe cuántos tienen 
             * notas mayores o iguales a 7 y cuántos menores.Para resolver este problema se 
             * requieren tres contadores*/

            for (i = 0; i < 10;i++ )
            {
                Console.WriteLine("Digite la nota del alumno");
                nota=float.Parse(Console.ReadLine());
                if (nota> 7)
                    cont++;
                else
                {
                    if (nota < 7)
                        cont2++;
                    else
                        cont3++;
                    
                }
            }

            Console.WriteLine("La cantidad de notas mayores de 7 son :"+cont);
            Console.WriteLine("La cantidad de notas menores de 7 son :" + cont2);
            Console.WriteLine("La cantidad de notas iguales de 7 son :" + cont3);
            Console.ReadKey();
        }
    }
}
