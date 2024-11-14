namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //adding items to the menu
            Restaurant restaurant = new Restaurant();
            restaurant.AddToMenu(new MenuItem(1, "Tomato soup", 39.99m));
            restaurant.AddToMenu(new MenuItem(2, "French onion soup", 29.99m));
            restaurant.AddToMenu(new MenuItem(3, "Miso soup", 59.99m));
            restaurant.AddToMenu(new MenuItem(4, "Ramen soup", 79.99m));

            restaurant.ShowMenu();
        }
    }
}
