using System.Collections.Generic;

namespace GenericCollections
{
    internal class Restaurant
    {
        //just wanted to see if there would be any different
        private List<MenuItem> _menuItem;
        private Queue<Order> _order = new Queue<Order>();

        public Restaurant()
        {
            _menuItem = new List<MenuItem>();
            _order = new Queue<Order>();
        }

        //adds food to the menu
        public void AddToMenu(MenuItem menuItem)
        {
            _menuItem.Add(menuItem);
            Console.WriteLine($"{menuItem} is now added to the menu.");
        }

        //method explains it
        public void ShowMenu()
        {

            Console.WriteLine("----------------------");
            Console.WriteLine("Menu: ");
            //menu is the var varible in _menuItem
            foreach (var menu in _menuItem)
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine("----------------------\n");
        }

        //creates and adds the order
        public void CreateOrder(Order order)
        {
            _order.Enqueue(order);
            Console.WriteLine($"Order: {order}");
            //Console.WriteLine("----------------------");
        }

        //dequeing part - handles the order
        public void HandleOrder()
        {
            if (_order.Count > 0)
            {
                ToString();
                Console.WriteLine($"Handleing order: {_order.Dequeue()}");
                Console.WriteLine("----------------------");
            }
            else
            {
                Console.WriteLine("No more orders in line");
            }
        }

        //methodname explains it

        public void ShowOrder()
        {
            //shows every order in que/line (samesame)
            foreach(var orders in _order)
            {
                Console.WriteLine($"There are {orders} orders in line.");
                //Console.WriteLine("----------------------");
            }
        }

        //method name explains it
        public void ShowNextOrer()
        {
            //peek peeks into the next order
            Console.WriteLine($"Next order in line: {_order.Peek()}");
        }

        //writes out the amount the orders in que
        public void ShowOrderCount()
        {
            foreach(var showOrder in _order)
            {
                Console.WriteLine(showOrder);
            }
        }
    }
}
