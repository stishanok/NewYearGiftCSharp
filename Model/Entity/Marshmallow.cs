namespace Model.Entity
{
    public class Marshmallow : BaseSweet
    {
        public bool Vanillin { get; private set; }
        public KindMarshmallow Kind { get; private set; }
        
        Marshmallow() {}

        Marshmallow(string name, double weight, decimal price, KindManufacturer manufacturer, double sugar,
            bool vanillin, KindMarshmallow kind) : base(name, weight, price, manufacturer, sugar)
        {
            Vanillin = vanillin;
            Kind = kind;
        }

        public override string ToString()
        {
            return base.ToString() +
                   " | Kind: " + Kind +
                   " | Vanillin: " + Vanillin;
        }
    }
}