using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass
{
    static void escribeUnaLetraX()
    {
        escribeUnaLetra('X');
    }

    static void escribeUnaLetraY()
    {
        escribeUnaLetra('Y');
    }

    static void escribeUnaLetra(Char letra)
    {
        Parallel.For(0, 1000, i =>
        {
            Console.Write(letra);
            i++;
        });
    }

    public static void Main(string[] args)
    {
        Thread t = new Thread(escribeUnaLetraY);
        t.Start();
        escribeUnaLetraX();
        Console.ReadKey();
    }
}