using System.Collections.Generic;

namespace GenericCollections
{
    internal class Restaurant
    {
        //just wanted to see if there would be any different
        private List<MenuItem> _menuItem = new List<MenuItem>();
        private Queue<Order> _order;

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

        public void CreateOrder(Order order)
        {
            //null checks the order parameter and ensure it is not null before enqueuing 
            if (order != null)
            {
                _order.Enqueue(order);
                Console.WriteLine($"The order is now created: {order}");
                Console.WriteLine("----------------------");
            }
            else
            {
                Console.WriteLine("Can not create an empty order");
            }
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
            //count shows every order and foreach shows every order in line
            if (_order.Count > 0)
            {
                //shows every order in que/line (samesame)
                //Console.WriteLine("Current orders in line: ");
                foreach (var order in _order)
                {
                    Console.WriteLine($"There are {order} orders in line.");
                }
            }
            else
            {
                Console.WriteLine("The que is empty.");
            }
            Console.WriteLine("----------------------");
        }

        //method name explains it
        public void ShowNextOrder()
        {
            //peek peeks into the next order
            if (_order.Count > 0)
            {
                Console.WriteLine($"Next order in line: {_order.Peek()}");
                Console.WriteLine("----------------------");

            }
            else
            {
                Console.WriteLine("The que is empty");
            }
        }

        //writes out the amount the orders in que
        public void ShowOrderCount()
        {
            //shows the count in the order
            Console.WriteLine(_order.Count);
            Console.WriteLine("----------------------");
        }
    }
}

//returns a copy to preserve encapulation
//public Queue<Order> order()
//{
//    return new Queue<Order>(_order);
//}