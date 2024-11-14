namespace GenericCollections
{

    internal class Restaurant
    {
        private List<MenuItem> _menuItem;
        private Queue<Order> _order;

        public Restaurant()
        {
            _menuItem = new List<MenuItem>();
            _order = new Queue<Order>();
        }
        public void AddToMenu(MenuItem menuItem)
        {
            _menuItem.Add(menuItem);
        }

        public void ShowMenu()
        {
            Console.WriteLine("Menu: ");
            //menu is the var varible in _menuItem
            foreach (var menu in _menuItem)
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine("----------------------");
        }

        public void CreateOrder(Order order)
        {
            _order.Enqueue(order);
            Console.WriteLine($"Order: {order}");
        }

        //dequeing part
        public void HandleOrder()
        {
            if (_order.Count > 0)
            {
                _order.Dequeue();
                Console.WriteLine($"Handleing order: {_order}");
            }
            else
            {
                Console.WriteLine("No more orders in line");
            }
        }

        public void ShowOrder()
        {

        }

        public void ShowNextOrer()
        {
            _order.Peek();
        }

        public void ShowOrderCount()
        {

        }
    }
}
