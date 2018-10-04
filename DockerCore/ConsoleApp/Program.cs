using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            while(true){
                
                Thread.Sleep(2000);
                Console.WriteLine(String.Format("Hello World From Docker Core times {0}",i++));
            }
        }
    }
}
