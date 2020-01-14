using Builder.Builder;
using Builder.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new CarBuilder();
            director.Builder = builder;

            Console.WriteLine("SUV");
            director.MakeSUV();
            Console.WriteLine(builder.GetCar().ListParts());
        }
    }
}
