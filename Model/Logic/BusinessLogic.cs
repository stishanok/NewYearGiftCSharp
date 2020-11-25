using System;
using System.Collections.Generic;
using Model.Entity;

namespace Model
{
    public class BusinessLogic
    {
        public Gift CreateGiftByWeight(string name, double weight, Sweet sweets)
        {
            Gift gift = new Gift(name);
            SortByWeight(sweets);
            bool flag = true;

            while (weight > 0 && flag)
            {
                foreach (Sweet sweet in sweets)
                {
                    
                }
            }
            
            
            return gift;
        }

        public static void SortByName(Sweet sweet, bool asc = true)
        {
            if (asc)
            {
                sweet.sweets.Sort(Comparator.NameComparerAsc);
            }
            else
            {
                sweet.sweets.Sort(Comparator.NameComparerDesc);
            }
        }
        
        public static void SortByWeight(Sweet sweet, bool asc = true)
        {
            if (asc)
            {
                sweet.sweets.Sort(Comparator.WeightComparerAsc);
            }
            else
            {
                sweet.sweets.Sort(Comparator.WeightComparerDesc);
            }
        }
        
        public static void SortByPrice(Sweet sweet, bool asc = true)
        {
            if (asc)
            {
                sweet.sweets.Sort(Comparator.PriceComparerAsc);
            }
            else
            {
                sweet.sweets.Sort(Comparator.PriceComparerDesc);
            }
        }
        
        public static void SortByManufacturer(Sweet sweet, bool asc = true)
        {
            if (asc)
            {
                sweet.sweets.Sort(Comparator.ManufacturerComparerAsc);
            }
            else
            {
                sweet.sweets.Sort(Comparator.ManufacturerComparerDesc);
            }
        }
        
        public static void SortBySugar(Sweet sweet, bool asc = true)
        {
            if (asc)
            {
                sweet.sweets.Sort(Comparator.SugarComparerAsc);
            }
            else
            {
                sweet.sweets.Sort(Comparator.SugarComparerDesc);
            }
        }
    }
}