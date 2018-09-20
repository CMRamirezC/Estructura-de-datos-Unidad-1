using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04._Suma_de_numeros_naturales
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
                    int[] numeros = new int[9] {1,2,3,4,5,6,7,8,9};
                    int Suma4n = 0;
                    int Suma9n = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        Suma4n = Suma4n + numeros[i];
                    }
                    for (int i = 0; i < 9; i++)
                    {
                        Suma9n = Suma9n + numeros[i];
                    }
                    Console.WriteLine(" La suma de los primeros 4 numeros naturales es: {0} \n y la suma de los primeros 9 numeros naturales es: {1}", Suma4n, Suma9n);
                    v = false;
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
