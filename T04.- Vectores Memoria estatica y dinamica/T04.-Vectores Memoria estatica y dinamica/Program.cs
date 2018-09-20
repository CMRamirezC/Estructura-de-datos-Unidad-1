using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04._Vectores_Memoria_estatica_y_dinamica
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
                    int cont = 0;
                    Console.Write(" Cuantas clases son?: ");
                    int numC = int.Parse(Console.ReadLine());
                    string[] clases = new string[numC];
                    int[] alumnos = new int[numC];
                    int[] calificacion = new int[numC];
                    for (int i = 0; i < clases.Length; i++)
                    {
                        Console.Write(" *Introduce la clase No.{0}: ", i + 1);
                        clases[i] = Console.ReadLine();
                        Console.Write(" *Introduce la cantidad maxima de alumnos para esta clase: ");
                        alumnos[i] = int.Parse(Console.ReadLine());
                        Console.Write(" *Introduce tu calificacion en esta clase: ");
                        calificacion[i] = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    foreach (string n in clases)
                    {
                        Console.Write(" " + n + ": {0} alumnos max \n tu calificacion es de: {1}\n", alumnos[cont], calificacion[cont]);
                        cont++;
                    }
                    Console.Write("\n Deseas volver a inicar el programa?: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    switch(Console.ReadLine().ToUpper())
                    {
                        case "SI":
                            v = true;
                            Console.Clear();
                            break;
                        case "NO":
                            v = false;
                            break;
                        default:
                            Console.WriteLine(" Error inesperado!!! Presiona cualquier tecla para continuar... ");
                            break;
                    }
                }
            } while (v == true);
        }
    }
}
