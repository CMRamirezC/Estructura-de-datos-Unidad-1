using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool v = true;
            do
            {
                try
                {
                    int[] numeros = new int[15];
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        Console.Write(" Introduce el numero en posicion {0} ({1} restantes): ", i + 1, 15 - i);
                        numeros[i] = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    int Suma4 = 0;
                    int Suma9 = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        Suma4 = Suma4 + numeros[i];
                    }
                    for (int i = 0; i < 9; i++)
                    {
                        Suma9 = Suma9 + numeros[i];
                    }
                    Console.WriteLine(" La suma de los primeros 4 numeros es: {0} \n y la suma de los primeros 9 es: {1}", Suma4, Suma9);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                }
            } while (v == true);
        }
    }
}
