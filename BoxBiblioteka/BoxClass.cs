using System;
using System.Collections.Generic;

namespace BoxBiblioteka
{
    public interface IBox
    {
        public void Add(IBox item);
        public double Cena();
        public double GetCenaJednostkowa();
    }
    public class Box : IBox
    {
        List<IBox> content = new List<IBox>();
        private double cena;
        public Box(double cena)
        {
            this.cena = cena;
        }
        public void Add(IBox item)
        {
            content.Add(item);
        }

        public double Cena()
        {
            double Cena = this.GetCenaJednostkowa();
            foreach (IBox item in content)
            {
                Cena += item.Cena();
            }
            return Cena;
        }

        public double GetCenaJednostkowa()
        {
            return this.cena;
        }
    }
    public class Item : IBox
    {
        private double cena;
        public Item(double cena)
        {
            this.cena = cena;
        }
        public void Add(IBox item)
        {
            return;
        }

        public double Cena()
        {
            return GetCenaJednostkowa();
        }

        public double GetCenaJednostkowa()
        {
            return this.cena;
        }
    }
    public class Container : IBox
    {
        List<Box> order = new List<Box>();
        public void Add(IBox item)
        {
            if (item.GetType() == typeof(Item)) return;
            order.Add((Box)item);
        }

        public double Cena()
        {
            double Cena = 0;
            foreach (IBox item in order)
            {
                Cena += item.Cena();
            }
            return Cena;
        }

        public double GetCenaJednostkowa()
        {
            return 0;
        }
    }
}
