namespace PizzaShop.Products
{
    class Pizza : IProduct
    {
        public Pizza(string name, decimal price, PizzaSize size)
        {
            Name = name;
            Price = price;
            Size = size;
        }

        public string Name { get; }
        public decimal Price { get; }
        public PizzaSize Size { get; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Pizza))
                return false;

            var otherPizza = (Pizza)obj;

            return Name == otherPizza.Name && Size == otherPizza.Size;
        }
    }
}