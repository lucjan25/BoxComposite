using System;
using BoxBiblioteka;

namespace BoxTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container sektor1 = new Container();
            Container sektor2 = new Container();

            Box box1 = new(500.50);
            Box box2 = new(22.2);
            Box box3 = new(1.1);
            Box box4 = new(0.7);

            Item item1 = new(40.1);
            Item item2 = new(1.7);
            Item item3 = new(0.6);
            Item item4 = new(943.0);
            Item item5 = new(14.5);
            Item item6 = new(.81);

            box1.Add(box2);
            box2.Add(item1);
            sektor1.Add(box1);
            sektor2.Add(box3);
            box3.Add(box4);
            box3.Add(item2);
            box1.Add(item3);
            box4.Add(item4);
            box2.Add(item5);
            box4.Add(item6);

            Console.WriteLine("Cena kontenera 1:" + sektor1.Cena());
            Console.WriteLine("Cena kontenera 2:" + sektor2.Cena());
        }
    }
}
