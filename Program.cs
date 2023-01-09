using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedzivanjePolimorfizam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Desert
    {
        private string name;
        private double weight;
        private int calories;

        public Desert(string name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }

        public override string ToString()
        {
            return name + " weight= " + weight + ", calories= " + calories;
        }

        public string getDessertType()
        {
            return "dessert";
        }
    }
}
