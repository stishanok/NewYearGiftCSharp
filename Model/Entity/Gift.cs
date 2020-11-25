using System.Collections.Generic;

namespace Model.Entity
{
    public class Gift
    {
        public static string DEFAULT_STR = "Default";
        public static double DEFAULT_WEIGHT = 0;
        public static decimal DEFAULT_COST = 0;
        public string Name { get; set; }
        public double Weight { get; private set; }
        public decimal Cost { get; set; }
        public List<BaseSweet> sweets;

        public Gift()
        {
            Name = DEFAULT_STR;
            Weight = DEFAULT_WEIGHT;
            Cost = DEFAULT_COST;
            sweets = new List<BaseSweet>();
        }

        public Gift(string name) : this()
        {
            Name = name;
        }

        public Gift(Gift gift)
        {
            Name = gift.Name;
            Weight = gift.Weight;
            Cost = gift.Cost;
            this.sweets = gift.sweets;
        }

        public void Add(BaseSweet sweet)
        {
            sweets.Add(sweet);
        }

        public bool Remove(BaseSweet sweet)
        {
            return sweets.Remove(sweet);
        }
        
    }
}