namespace Model.Entity
{
    public class Candy : BaseSweet
    {
        public KindCandy Kind { get; private set; }

        public Candy() {}

        public Candy(string name, double weight, decimal price, KindManufacturer manufacturer, double sugar,
            KindCandy kind) : base(name, weight, price, manufacturer, sugar)
        {
            Kind = kind;
        }

        public override string ToString()
        {
            return base.ToString() +
                   " | Kind: " + Kind;
        }
    }
}