using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arProg = new ArithProgression();
            arProg.SetStart(0);
            arProg.SetStep(5);
            Console.WriteLine(arProg.GetNext());
            Console.WriteLine(arProg.GetNext());
            Console.WriteLine(arProg.GetNext());
            Console.WriteLine(arProg.GetNext());
            arProg.Reset();
            Console.WriteLine(arProg.GetNext());
            Console.WriteLine(arProg.GetNext());

            Console.WriteLine();
            GeomProgression geomProg = new GeomProgression();
            geomProg.SetStart(3);
            geomProg.SetStep(10);
            Console.WriteLine(geomProg.GetNext());
            Console.WriteLine(geomProg.GetNext());
            Console.WriteLine(geomProg.GetNext());
            geomProg.Reset();
            Console.WriteLine(geomProg.GetNext());
            Console.WriteLine(geomProg.GetNext());
            Console.ReadKey();
        }
    }
}
