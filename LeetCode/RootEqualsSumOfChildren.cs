using BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class RootEqualsSumOfChildren
    {
        public static bool CheckTree(TreeNode<int> root)
        {
            int sum = 0;
            if (root.Value == CheckEachNode(root,ref sum)-root.Value)
                return true;
            return false;
        }

        private static int CheckEachNode(TreeNode<int> root, ref int sum)
        {
             if(root == null)
                return 0;
            CheckEachNode(root.Left,ref sum);
            sum+=root.Value;
            CheckEachNode(root.Right,ref sum);

            return sum;
        }
    }
}
