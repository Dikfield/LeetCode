using BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class AllElementsInTwoBinarySearchTrees
    {
        public static IList<int> GetAll = new List<int>();

        public static IList<int> GetAllElements(Bst<int> root1, Bst<int> root2)
        {
                        
            GetElements(root1, root2);
            
            return GetAll;
        }

        public static void GetElements(Bst<int> a, Bst<int> b)
        {
            var numbers = a.TraverseInOrder();
            var numbers2 = b.TraverseInOrder();
            foreach(var number in numbers)
            {
                GetAll.Add(number);
            }

            foreach (var number in numbers2)
            {
                GetAll.Add(number);
            }
        }
    }
}
