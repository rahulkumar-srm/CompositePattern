using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Menu : MenuComponent
    {
        private List<MenuComponent> menuComponents = new List<MenuComponent>();
        private string name, description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponent.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override void Print()
        {
            Console.Write("\n" + GetName());
            Console.WriteLine(",  ", GetDescription());
            Console.WriteLine("-------------------");

            var iterator = menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                iterator.Current.Print();
            }
        }
    }
}
