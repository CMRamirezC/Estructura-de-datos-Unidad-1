using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.__Calculo_de_tiempo_de_ejecicion
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tiempo1 = DateTime.Now;
            int suma = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine(" La suma de los numeros del 1-1,000,000 es: {0} ", suma);
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.Write("\n TIEMPO: " + total.ToString());
            Console.ReadKey();
        }
    }
}
