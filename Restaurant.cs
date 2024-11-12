namespace GenericCollections
{
 
    internal class Restaurant
    {
        //to represent the menu
        private List<MenuItem> menu = new List<MenuItem>();
        //FIFO - first in, first out
        Queue<Order> orders = new Queue<Order>();

        //adds new cuisine in the menu and add it to the console?
        public void AddToMenu(MenuItem menuItem)
        {

        }

        //shows everything in the menu
        public void ShowMenu()
        {
            foreach(var item in menu)
            {
                Console.WriteLine(item);
            }
        }

        //enters new order in line and logs it to the console
        public void CreateOrder(Order order)
        {

        }

        //handles (dequeue) the first order and logs det in the console
        public void HandleOrder()
        {

        }

        //Show all the orders in line in the console
        public void ShowOrder()
        {

        }

        //outputs the next in line order and logs it in the console
        public void ShowNextOrer()
        {

        }

        //outputs the amount orders in line
        public void ShowOrderCount()
        {

        }
    }
}
