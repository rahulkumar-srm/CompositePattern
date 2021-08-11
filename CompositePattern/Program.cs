using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent panCakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(panCakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Vegeterian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29));
            dinerMenu.Add(new MenuItem("Hotdog", "A hotdog with saurkraut, relish, onions, topped with cheese", false, 3.05));
            dinerMenu.Add(dessertMenu);

            panCakeHouseMenu.Add(new MenuItem("K&B Pancake Breakfast", "Pancake with scrambled eggs and toast", false, 2.99));
            panCakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancake with fried eggs and sausage", false, 2.99));
            panCakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            panCakeHouseMenu.Add(new MenuItem("Waffles", "With your choice of blueberries or strawberries", true, 3.59));

            cafeMenu.Add(new MenuItem("Veggie burge and air fries", "Veggie burger on a whole wheat bun, lettuce, tomato and fries", true,  3.99));
            cafeMenu.Add(new MenuItem("Burrito", "A large burrito with whole pinto beans, salsa, guacamole", true, 4.29));

            dessertMenu.Add(new MenuItem("Apple pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59));

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
