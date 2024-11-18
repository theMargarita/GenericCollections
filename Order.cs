namespace GenericCollections
{
    internal class Order
    {
        string NL = Environment.NewLine; // shortcut
        string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
        string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
        string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
        string UNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[4m";
        string NOUNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[24m";


        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            this.tableNumber = tableNumber;
        }

        //method for calculate the total price of the order
        public decimal Total()
        {
            decimal total = 0;
            foreach (var item in _orderItems)
            {
                total += item.Price;
            }
            return total;
        }
       
        //Method for printing correct order
        public void PrintOrder()
        {
            Console.WriteLine($"{YELLOW}Order {_orderId}{NORMAL}");
            //every menuitem in orderITems to show the correct order with name, food, and the exact price
            foreach(var menuItems in _orderItems)
            {
                //to specify the menu items name and price 
                Console.WriteLine($"{menuItems.Name} - {menuItems.Price:C}");
            }
            Console.WriteLine($"Table number: {tableNumber}\n{UNDERLINE}Total: {Total():C}{NOUNDERLINE}");
            Console.WriteLine();
        }

        public bool FinishedOrder()
        {
            bool finishedOrder = true;
            return finishedOrder;
        }

        //converts an object to its string representation so that it is sutible for display
        //to under stand the ToString method more
        public override string ToString()
        {
            //
            return ($"{YELLOW}Order number:{NORMAL} {_orderId}\n" +
                $"Table number: {tableNumber}\nTotal: {Total():C}\n ");
        }
    }
}
