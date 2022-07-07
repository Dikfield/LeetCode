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
        
        public static IList<int> GetAllElements(TreeNode<int> root1, TreeNode<int> root2)
        {
            List<int> getAll = new List<int>();

            TraverseInOrder(root1, getAll);
            TraverseInOrder(root2, getAll);

            getAll.Sort();

            return getAll;
        }
        public static void TraverseInOrder(TreeNode<int> root, List<int> getAll)
        {
            if (root == null)
                return;

            TraverseInOrder(root.Left, getAll);
            getAll.Add(root.Value);
            TraverseInOrder(root.Right, getAll);

        }
    }
}
