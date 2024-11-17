using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NL = Environment.NewLine; // shortcut
            string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
            string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
            string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
            string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";

            //adding items to the menu - constructor 
            Restaurant restaurant = new Restaurant();

            MenuItem menu1 = new MenuItem(1, "Tomato soup", 40m );
            MenuItem menu2 = new MenuItem(2, "French Onion soup", 35m);
            MenuItem menu3 = new MenuItem(3, "Miso soup", 80m);
            MenuItem menu4 = new MenuItem(4, "Ramen soup", 95m);
            MenuItem menu5 = new MenuItem(5, "Italian soup", 50m);

            restaurant.AddToMenu(menu1);
            restaurant.AddToMenu(menu2);
            restaurant.AddToMenu(menu3);
            restaurant.AddToMenu(menu4);
            restaurant.AddToMenu(menu5);

            restaurant.ShowMenu();

            Console.WriteLine($"{CYAN}Added orders:{NORMAL} ");
            
            var orderMenu1 = new List<MenuItem> { menu1, menu2};
            var order1 = new Order(orderMenu1, 11);
            restaurant.CreateOrder(order1);

            var orderMenu2 = new List<MenuItem> { menu3, menu4 };
            var order2 = new Order(orderMenu2, 22);
            restaurant.CreateOrder(order2);

            var orderMenu3 = new List<MenuItem> { menu1, menu5 };
            var order3 = new Order(orderMenu3, 33);
            restaurant.CreateOrder(order3);

            restaurant.ShowOrder();

            restaurant.HandleOrder();



            restaurant.ShowOrderCount();

            restaurant.ShowNextOrder();

        }
    }
}
