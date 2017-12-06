using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            Text text = new Text();
            Shape shape = text;      //Text and Shape objects pointing to(references to) same object in memory.  

            //conversion from a derived class to a base class
            text.Width = 200;
            shape.Width = 100;    

            Console.WriteLine(text.Width);  //100
        }
    }
}
