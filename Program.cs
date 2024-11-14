using System.Collections.Generic;
namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //adding items to the menu
            Restaurant restaurant = new Restaurant();
            //classname, variblename and new items to the class+methods and stuff
            restaurant.AddToMenu(new MenuItem(1, "Tomato soup", 40m));
            restaurant.AddToMenu(new MenuItem(2, "French onion soup", 30m));
            restaurant.AddToMenu(new MenuItem(3, "Miso soup", 65m));
            restaurant.AddToMenu(new MenuItem(4, "Ramen soup", 75m));
            restaurant.AddToMenu(new MenuItem(5, "Fish soup", 50m));
            //varible and show mehtod 
            restaurant.ShowMenu();
            Console.ReadKey();


            List<MenuItem> order1 = new List<MenuItem> { new MenuItem(1, "Tomato soup", 40m), 
            new MenuItem(2, "French onion soup", 30m), new MenuItem(4, "Ramen soup", 75m)};

            List<MenuItem> order2 = new List<MenuItem> { new MenuItem(2, "French onion soup", 40m),
            new MenuItem(2, "French onion soup", 30m), new MenuItem(5, "Fish soup", 75m)};

            List<MenuItem> order3 = new List<MenuItem> { new MenuItem(3, "Miso soup", 65m),
            new MenuItem(5, "Fish soup", 65m), new MenuItem(4, "Ramen soup", 75m)};

            restaurant.CreateOrder(new Order(order1, 1));
            restaurant.CreateOrder(new Order(order2, 2));
            restaurant.CreateOrder(new Order(order3, 3));

            //Order orders1 = new Order(order1, 1);
            //Order orders2 = new Order(order2, 2);
            //Order orders3 = new Order(order3, 3);
            //restaurant.CreateOrder(orders1);
            //restaurant.CreateOrder(orders2);
            //restaurant.CreateOrder(orders3);

            restaurant.ShowOrder();
            Console.ReadKey();
            restaurant.HandleOrder();
            Console.ReadKey();
            restaurant.ShowNextOrer();
            Console.ReadKey();
            restaurant.ShowOrderCount();
        }
    }
}
