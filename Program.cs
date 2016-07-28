using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is testing comment
namespace ConsoleApplication1
{
    class demo
    {
        public int x;
       public int speed
        {
            get{
                return x;
            }
            set{
                if((value>0)&&(value<120)){
                    x = value;
                }
               }
        }
    }
	//Random comment
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            d.x = 100;
			Console.WriteLine("Welcome to c#");
            Console.WriteLine($"Value assigned{d.x}");
           Console.ReadLine();

        }
    }
}
