namespace VentasCoches_v3
{
    internal class Component
    {
        public string Name { get; }
        public int Price { get; }

        public Component(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}