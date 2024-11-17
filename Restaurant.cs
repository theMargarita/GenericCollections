using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace GenericCollections
{
    internal class Restaurant
    {
        string NL = Environment.NewLine; // shortcut
        string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
        string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
        string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";

        public List<MenuItem> _menuItem = new List<MenuItem>();
        public Queue<Order> _order = new Queue<Order>();

        //adds le plat to the menu
        public void AddToMenu(MenuItem menuItem)
        {
            _menuItem.Add(menuItem);
            //to specify the namne of le plat
            Console.WriteLine($"{CYAN}Added course:{NORMAL} {menuItem.Name} ");
        }

        //method explains it
        public void ShowMenu()
        {
            Console.WriteLine($"\n{CYAN}Menu:{NORMAL} ");
            foreach (var menu in _menuItem)
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine("----------------------\n");
        }

        public void CreateOrder(Order order)
        {
            //null checks the order parameter and ensure it is not null before enqueuing
            _order.Enqueue(order);
            Console.WriteLine($"Order {_order.Count} is now added");
        }


        //dequeing part - handles the order
        public void HandleOrder()
        {
            var items = new List<MenuItem>();
            //for (int i = 0; i > _order.Count; i++)
            //{
               
            //}
            //if(_order.Count > 0)
            //{
            //    _order.Dequeue();
            //}
            //ToString();
            Console.WriteLine($"{CYAN}Handling:{NORMAL}\nOrder: {_order.Count}");
            Console.WriteLine("----------------------");

        }

        public void ShowOrder()
        {
            Console.WriteLine();

            //count shows every order and foreach shows every order in line
            Console.WriteLine($"{CYAN}Current orders in line:{NORMAL} ");

            //_order.Dequeue();
            foreach (var order in _order)
            {
                Console.WriteLine(order.PrintOrder);
            }
            Console.WriteLine("----------------------");
        }

        public void ShowNextOrder()
        {
            //peek peeks into the next order
            Console.WriteLine($"{CYAN}Next order in line:{NORMAL} ");
            if (_order.Count > 0)
            {
                Console.WriteLine(_order.Peek());
            }
            else
            {
                Console.WriteLine("The que is empty");
            }
            Console.WriteLine();
        }

        //writes out the amount the orders in que
        public void ShowOrderCount()
        {
            //shows the count in the order
            Console.WriteLine();
            Console.WriteLine($"{YELLOW}Orders in line:{NORMAL}\n{_order.Count}");
            Console.WriteLine();
        }
    }
}

