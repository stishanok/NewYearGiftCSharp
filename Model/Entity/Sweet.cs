using System.Collections;
using System.Collections.Generic;

namespace Model.Entity
{
    public class Sweet : IEnumerable
    {
        private static string MSG_SWEET_IS_EMPTY = "Sweets is empty";
        
        public List<BaseSweet> sweets;

        public Sweet()
        {
            sweets = new List<BaseSweet>();
        }

        public override string ToString()
        {
            string result = "";
            
            if (IsEmpty())
            {
                result = MSG_SWEET_IS_EMPTY;
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

        public System.Collections.IEnumerator GetEnumerator()
        {
            return sweets.GetEnumerator();
        }
        
        bool IsEmpty()
        {
            return sweets.Count == 0;
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