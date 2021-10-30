using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression prog1 = new ArithProgression();
            prog1.setStart(5);
            Console.WriteLine(prog1.getNext());
            prog1.recet();
            Console.WriteLine(prog1.getNext());
            GeomProgression prog2 = new GeomProgression();
            prog2.setStart(100);
            Console.WriteLine(prog2.getNext());
            prog2.recet();
            Console.WriteLine(prog2.getNext());
            Console.ReadKey();
        }
        interface ISeriese
        {
            int X { get; set; }
            void setStart(int x);
            int getNext();
            void recet();
        }
        class ArithProgression : ISeriese
        {
            public int X { get; set; }
            public void recet()
            {
                int X = 0;
            }
            public void setStart(int x)
            {
                X = x;
            }
            public int getNext()
            {
                int x = X + 2;
                return x;
            }
        }
        class GeomProgression : ISeriese
        {
            public int X { get; set; }
            public void recet()
            {
                int X = 0;
            }
            public void setStart(int x)
            {
                int X = x;
            }
            public int getNext()
            {
                int x = X * 2;
                return x;
            }
        }
    }
}
