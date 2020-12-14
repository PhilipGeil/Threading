using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    //----------------------------------------------------------------------------
    // OPGAVE 0-1-2 BESVARELSE
    //class Program
    //{

    //    public void WorkThreadFunction(object s)
    //    {
    //        string msg = s as string;

    //        if (msg != null)
    //        {

    //            for (int i = 0; i < 5; i++)
    //            {
    //                Console.WriteLine(msg);
    //                Thread.Sleep(1000);
    //            }
    //        }
    //    }
    //}

    //class Threprog
    //{
    //    static void Main(string[] args)
    //    {
    //        Program pg = new Program();
    //        Thread thread = new Thread(pg.WorkThreadFunction);
    //        Thread th = new Thread(pg.WorkThreadFunction);
    //        thread.Name = "Thread number 1";
    //        th.Name = "Thread number 2";
    //        thread.Start("C#-trådning er nemt!");
    //        th.Start("Også med flere tråde...");
    //        Console.Read();
    //    }
    //}
    //----------------------------------------------------------------------------


    //----------------------------------------------------------------------------
    // OPGAVE 3 BESVARELSE
    //class Program
    //{
    //    static int temp;
    //    static Random rand = new Random();
    //    static int errors = 0;
    //    static void Main()
    //    {
    //        Thread th = new Thread(GenerateTemp);
    //        th.Name = "Temp Thread";
    //        th.Start();

    //        Thread.CurrentThread.Name = "Main Thread";

    //        while (th.IsAlive)
    //        {
    //            Thread.Sleep(10000);
    //            Console.WriteLine("{0} - Temp Thread alive: {1}", Thread.CurrentThread.Name, th.IsAlive);
    //        }

    //        Console.WriteLine("Done");
    //    }

    //    static void GenerateTemp()
    //    {
    //        while (errors != 3)
    //        {
    //            temp = rand.Next(-20, 120);
    //            Console.WriteLine("{0} - {1}", Thread.CurrentThread.Name, temp);
    //            if (temp < 0 || temp > 100)
    //            {
    //                errors++;
    //                Console.WriteLine("ERROR TEMP IS DANGEROUS");
    //            }
    //            Thread.Sleep(2000);
    //        }
    //    }
    //}
    //----------------------------------------------------------------------------


    //----------------------------------------------------------------------------
    class Program
    {
        static char ch = '*';
        static void Main()
        {

            Thread t1 = new Thread(ReadInput);
            Thread t2 = new Thread(PrintChar);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            //while (t1.IsAlive && t2.IsAlive)
            //{
            //}
            Console.WriteLine("We are done now");

        }

        static void ReadInput()
        {
            char cha = '*';

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    ch = cha;
                }
                else
                {
                    cha = keyInfo.KeyChar;

                } 
            }
        }

        static void PrintChar()
        {
            while (true)
            {
                Thread.Sleep(100);
                Console.Write(ch);
            }
        }
    }
    //----------------------------------------------------------------------------



    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("[{0}] Main called", Thread.CurrentThread.ManagedThreadId);

    //        for (int n = 0; n < 10; n++)
    //        {
    //            //pool, kald af metode plus argument n
    //            ThreadPool.QueueUserWorkItem(SayHello, n);
    //        }

    //        //2 Thread.Sleep(rng.Next(1000, 3000));
    //        //1 Thread.Sleep(rng.Next(250, 500));
    //        Console.WriteLine("[{0}] Main done", Thread.CurrentThread.ManagedThreadId);
    //        Console.ReadKey();
    //    }

    //    static Random rng = new Random();


    //    //Callback metode
    //    static void SayHello(object arg)
    //    {
    //        //1 Thread.Sleep(rng.Next(250, 500));

    //        int n = (int)arg;

    //        Console.WriteLine("[{0}] Hello, world {1}! ({2})",
    //                          Thread.CurrentThread.ManagedThreadId,
    //                          n,
    //                          Thread.CurrentThread.IsBackground);
    //    }
    //}
}
