namespace PizzaShop.Products
{
    class Drink : IProduct
    {
        public Drink(string name, decimal price, DrinkVolume volume)
        {
            Name = name;
            Price = price;
            Volume = volume;
        }

        public string Name { get; }
        public decimal Price { get; }
        public DrinkVolume Volume { get; }
    }
}