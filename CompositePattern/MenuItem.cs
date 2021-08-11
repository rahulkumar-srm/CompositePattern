using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class MenuItem : MenuComponent
    {
        private string name;
        private string description;
        private bool vegetarian;
        private double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsVegeterian()
        {
            return vegetarian;
        }

        public override void Print()
        {
            Console.Write(" " + GetName());
            if (IsVegeterian())
                Console.Write("(v)");

            Console.Write(", " + GetPrice());
            Console.WriteLine("    --  " + GetDescription());
        }
    }
}
