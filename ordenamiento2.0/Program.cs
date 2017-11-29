using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("METODO DE SELECCION");
            int[] numeros = { 34, 56, 76, 87, 90, 1 };
            int j;
            int h;
            int menor;
            int aux;

            // cogemos todo para organizar
            for (j = 0; j < numeros.Length - 1; j++)
            {
                // tratando de organizando iniciando con el menor 
                menor = j;
                // el contador tendra valor extra a h
                for (h = j + 1; h < numeros.Length; h++)
                {
                    if (numeros[h] < numeros[menor])
                        menor = h;
                }

                // 
                if (menor != j)
                {
                    aux = numeros[j];
                    numeros[j] = numeros[menor];
                    numeros[menor] = aux;
                }

                // Y muestro el progreso
                foreach (int dato in numeros)
                    Console.Write(dato + " ");
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
        
    

