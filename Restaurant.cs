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
            Console.WriteLine($"{YELLOW}Order {_order.Count}{NORMAL} is now added");
        }

        //dequeing part - handles the order
        public void HandleOrder()
        {
            if (_order.Count > 0)
            {
                //use nextOrder to later call the method with correct order handleing 
                var nextOrder = _order.Dequeue();
                Console.WriteLine($"{CYAN}Handeling: {NORMAL}");
                //to print the order from the method in orderclass
                nextOrder.PrintOrder();
                nextOrder.FinishedOrder();
                Console.WriteLine($"{CYAN}Finished order:{NORMAL} \n{nextOrder}");
            }
            else
            {
                Console.WriteLine("No more orders to handle.");
            }
        }

        public void ShowOrder()
        {
            //count shows every order and foreach shows every order in line
            Console.WriteLine($"{CYAN}Current orders in line:{NORMAL} ");

            foreach (var order in _order)
            {
                order.PrintOrder();
            }
            Console.WriteLine("----------------------");
        }

        public void ShowNextOrder()
        {
            //peek peeks into the next order
            Console.WriteLine($"{CYAN}Next order in line:{NORMAL} ");
            if (_order.Count > 0)
            {
                var peekOrder = _order.Peek();
                peekOrder.PrintOrder();
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
            Console.WriteLine($"It is {CYAN}{_order.Count}{NORMAL} orders in line\n");
        }
    }
}

