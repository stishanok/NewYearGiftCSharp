using System;
using System.Collections.Generic;
using Model.Entity;
using System.Linq;
using static Util.UserInput;

namespace Model
{
    public class BusinessLogic
    {
        private const string MSG_GET_PRICE = "Enter price gift: ";
        private const string MSG_GET_WEIGHT = "Enter weight gift: ";
        private const string MSG_GET_MAX_PRICE = "Enter max price for sweet: ";
        private const string MSG_GET_MAX_WEIGHT = "Enter max weight for sweet: ";
        public static Gift CreateGiftByWeight(string name, Sweet sweets)
        {
            Gift gift = new Gift(name);
            SortByWeight(sweets, false);
            bool flag = true;
            double weight = GetPositivNumber(MSG_GET_WEIGHT);

            while (weight > 0 && flag)
            {
                foreach (BaseSweet sweet in sweets)
                {
                    if (sweet.Weight <= weight)
                    {
                        weight -= sweet.Weight;
                        gift.Cost += sweet.Price;
                        gift.Weight += sweet.Weight;
                        gift.Add(sweet);
                    }
                    else if (weight < sweets.sweets.Last().Weight)
                    {
                        flag = false;
                    }
                }
            }
            
            SortByName(gift);
            return gift;
        }

        public static Gift CreateGiftByCost(string name, Sweet sweets)
        {
            Gift gift = new Gift(name);
            SortByPrice(sweets, false);
            bool flag = true;
            decimal price = (decimal)GetPositivNumber(MSG_GET_PRICE);

            while (price > 0 && flag)
            {
                foreach (BaseSweet sweet in sweets)
                {
                    if (sweet.Price <= price)
                    {
                        price -= sweet.Price;
                        gift.Cost += sweet.Price;
                        gift.Weight += sweet.Weight;
                        gift.Add(sweet);
                    }
                    else if (price < sweets.sweets.Last().Price)
                    {
                        flag = false;
                    }
                }
            }
            
            SortByName(gift);
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
        
        public static void SortByName(Gift gift, bool asc = true)
        {
            if (asc)
            {
                gift.sweets.Sort(Comparator.NameComparerAsc);
            }
            else
            {
                gift.sweets.Sort(Comparator.NameComparerDesc);
            }
        }
        
        public static void SortByWeight(Gift gift, bool asc = true)
        {
            if (asc)
            {
                gift.sweets.Sort(Comparator.WeightComparerAsc);
            }
            else
            {
                gift.sweets.Sort(Comparator.WeightComparerDesc);
            }
        }
        
        public static void SortByPrice(Gift gift, bool asc = true)
        {
            if (asc)
            {
                gift.sweets.Sort(Comparator.PriceComparerAsc);
            }
            else
            {
                gift.sweets.Sort(Comparator.PriceComparerDesc);
            }
        }
        
        public static void SortByManufacturer(Gift gift, bool asc = true)
        {
            if (asc)
            {
                gift.sweets.Sort(Comparator.ManufacturerComparerAsc);
            }
            else
            {
                gift.sweets.Sort(Comparator.ManufacturerComparerDesc);
            }
        }
        
        public static void SortBySugar(Gift gift, bool asc = true)
        {
            if (asc)
            {
                gift.sweets.Sort(Comparator.SugarComparerAsc);
            }
            else
            {
                gift.sweets.Sort(Comparator.SugarComparerDesc);
            }
        }

        public static Sweet FilterSweetsByPrice(Sweet sweets)
        {
            Sweet result = new Sweet();
            decimal maxPrice = (decimal)GetPositivNumber(MSG_GET_MAX_PRICE);

            foreach (BaseSweet sweet in sweets)
            {
                if (sweet.Price <= maxPrice)
                {
                    result.Add(sweet);
                }
            }
            
            SortByPrice(result);
            return result;
        }
        
        public static Sweet FilterSweetsByWeight(Sweet sweets)
        {
            Sweet result = new Sweet();
            double maxWeight = GetPositivNumber(MSG_GET_MAX_WEIGHT);

            foreach (BaseSweet sweet in sweets)
            {
                if (sweet.Weight <= maxWeight)
                {
                    result.Add(sweet);
                }
            }
            
            SortByWeight(result);
            return result;
        }
    }
}