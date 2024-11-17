using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace GenericCollections
{
    internal class Order
    {
        string NL = Environment.NewLine; // shortcut
        string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
        string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
        string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";


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
       
        public void PrintOrder()
        {
            Console.WriteLine($"{_orderId}");
            foreach(var menuItems in _orderItems)
            {
                Console.WriteLine($"{menuItems.Name}, Total: {Total()}");
            }
        }


        //converts an object to its string representation so that it is sutible for display
        public override string ToString()
        {
            return ($"{YELLOW}Order number:{NORMAL} {orderIdCounter}\n" +
                $"Table number: {tableNumber}\nTotal: {Total():C}\n ");
        }


        //public void Orders()
        //{
        //    Console.WriteLine($"Order: {orderIdCounter}");
        //    foreach (var item in _orderItems)
        //    {
        //        Console.WriteLine($"1: {item.Name}");
        //    }

        //    Console.WriteLine($"Total amount: {Total:C} - Tablenumber: {tableNumber}");
        //    Console.WriteLine("---------------------");
        //}
    }
}
