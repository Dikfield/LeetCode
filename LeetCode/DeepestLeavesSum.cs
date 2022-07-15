using BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class DeepestLeavesSum
    {
        public static int DeepestLeaves(TreeNode<int> root)
        {
            int a =0;
            return TraverseInNode(root,ref a);

        }
        private static int TraverseInNode(TreeNode<int> root, ref int a)
        {
            
            if (root == null)
                return 0;

            if (root.Right == null)
                a = root.Value;
            TraverseInNode(root.Right, ref a);
            
            return a;
        }
    }
}
