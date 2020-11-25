namespace Model.Entity
{
    public class Comparator
    {
        public static int NameComparerAsc(BaseSweet x, BaseSweet y)
        {
            return x.Name.CompareTo(y.Name);
        }
        
        public static int NameComparerDesc(BaseSweet x, BaseSweet y)
        {
            return y.Name.CompareTo(x.Name);
        }
        
        public static int WeightComparerAsc(BaseSweet x, BaseSweet y)
        {
            return x.Weight.CompareTo(y.Weight);
        }
        
        public static int WeightComparerDesc(BaseSweet x, BaseSweet y)
        {
            return y.Weight.CompareTo(x.Weight);
        }
        
        public static int PriceComparerAsc(BaseSweet x, BaseSweet y)
        {
            return x.Price.CompareTo(y.Price);
        }
        
        public static int PriceComparerDesc(BaseSweet x, BaseSweet y)
        {
            return y.Price.CompareTo(x.Price);
        }
        
        public static int ManufacturerComparerAsc(BaseSweet x, BaseSweet y)
        {
            return x.Manufacturer.CompareTo(y.Manufacturer);
        }
        
        public static int ManufacturerComparerDesc(BaseSweet x, BaseSweet y)
        {
            return y.Manufacturer.CompareTo(x.Manufacturer);
        }
        
        public static int SugarComparerAsc(BaseSweet x, BaseSweet y)
        {
            return x.Sugar.CompareTo(y.Sugar);
        }
        
        public static int SugarComparerDesc(BaseSweet x, BaseSweet y)
        {
            return y.Sugar.CompareTo(x.Sugar);
        }
    }
}