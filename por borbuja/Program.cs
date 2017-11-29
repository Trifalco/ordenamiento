using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace por_borbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            // incializamos variables en cero 
            int j = 0;
            int i = 0;
            int[] numeros;
            // pedimos la cantidad de numeros a ordenar
            Console.WriteLine("cantidad deseada de ordenamiento");


            j = int.Parse(Console.ReadLine());


            numeros = new int[j];

            //pedimos los numeros las veces que nos pide el usuario  
            for (int a = 0; a < j; a++)
            {
                Console.Write("escriba el numero [{0}]:", a);
                numeros[a] = int.Parse(Console.ReadLine());
            }
            // hacemos el ordenamiento comparando los 2 y enviando el menor atras
            for (int b = 1; b < j; b++)
            {
                for (int c = 0; c < j - 1; c++)
                {
                    if (numeros[b] < numeros[c])
                    {
                        i = numeros[b];
                        numeros[b] = numeros[c];
                        numeros[c] = i;
                    }
                }
            }
            // mostramos el metodo uno por uno 
            for (int r = 0; r < j; r++)
                Console.WriteLine("{0}.-{1}", r + 1, numeros[r]);
            Console.Read();
        }
    }
}
