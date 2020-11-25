namespace Model.Entity
{
    public class Chocolate : BaseSweet
    {
        public double CacaoPercent { get; private set; }
        public KindChocolate Kind { get; private set; }
        
        public Chocolate() {}

        public Chocolate(string name, double weight, decimal price, KindManufacturer manufacturer, double sugar,
            double cacaoPercent,
            KindChocolate kind) : base(name, weight, price, manufacturer, sugar)
        {
            CacaoPercent = cacaoPercent;
            Kind = kind;
        }

        public override string ToString()
        {
            return base.ToString() +
                   " | Kind: " + Kind +
                   " | Cacao percent: " + CacaoPercent;
        }
    }
}