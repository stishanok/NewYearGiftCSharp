using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Model.Entity
{
    public class Gift : IEnumerable
    {
        public static string DEFAULT_STR = "Default";
        public static double DEFAULT_WEIGHT = 0;
        public static decimal DEFAULT_COST = 0;
        private static string MSG_GIFT_IS_EMPTY = "Gift is empty";
        public string Name { get; set; }
        public double Weight { get; set; }
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
            sweets = gift.sweets;
        }

        public void Add(BaseSweet sweet)
        {
            sweets.Add(sweet);
        }

        public bool Remove(BaseSweet sweet)
        {
            return sweets.Remove(sweet);
        }

        public override string ToString()
        {
            string result = "\nName gift: " + Name + ", Weight: " + Math.Round(Weight, 2) + ", Price: " + Math.Round(Cost, 2) + "\n";

            if (IsEmpty())
            {
                result += MSG_GIFT_IS_EMPTY;
            }
            else
            {
                foreach (BaseSweet sweet in sweets)
                {
                    result += sweet + "\n";
                }
            }

            return result;
        }
        
        bool IsEmpty()
        {
            return sweets.Count == 0;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return sweets.GetEnumerator();
        }
    }
}