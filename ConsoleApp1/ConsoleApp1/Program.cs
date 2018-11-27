using System;
using System.Threading;
using System.Collections.Concurrent;

namespace ConsoleApp1
{
    class Program
    {
        // se crea un diccionario (colección de datos) concurrente que se llenará con números del 1 al 100
        // usando dos procesos distintos.
        static ConcurrentDictionary<int, string> o = new ConcurrentDictionary<int, string>();
        
        static void Main(string[] args)
        {
            Thread proceso1 = new Thread(P1); // se crea el proceso 1
            Thread proceso2 = new Thread(P2); // se crea el proceso 2
            proceso1.Start();
            proceso2.Start();          
            Console.ReadLine();  // Linea únicamente para poder observar la consola
                                        // sin que termine el programa.  
        }

        static void P1()
        {
            for(int i=1; i< 101; i++)
            {
                o.TryAdd(i, "P1 número " + 1);
                Console.WriteLine("Proceso 1 agrego " + i); //muestra en pantalla que el proceso 1 agregó un número
            }
        }

        static void P2()
        {
            for(int i = 1; i< 101; i++)
            {
                o.TryAdd(i, "P2 número " + 1);
                Console.WriteLine("Proceso 2 agrego " + i); //muestra en pantalla que el proceso 2 agregó un número
            }

        }
     }
}
