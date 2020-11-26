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
        
        public override int GetHashCode()
        {
            return Name.GetHashCode() * Weight.GetHashCode() * Price.GetHashCode() * Manufacturer.GetHashCode() * Sugar.GetHashCode() * Kind.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this == obj) return true;
            
            Candy candy = obj as Candy;

            if (candy == null) return false;

            if (Name != candy.Name) return false;

            if (Weight != candy.Weight) return false;

            if (Price != candy.Price) return false;

            if (Manufacturer != candy.Manufacturer) return false;

            if (Sugar != candy.Sugar) return false;

            if (Kind != candy.Kind) return false;
            
            return true;
        }
    }
}