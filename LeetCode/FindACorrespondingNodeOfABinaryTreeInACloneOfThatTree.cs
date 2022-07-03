using BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
    {
        public static TreeNode<int> FindCorrespondingNode(TreeNode<int> treeNode, int target)
        {
            if (treeNode == null)
                return null;

            if (treeNode.Value == target)
                return treeNode;


            TreeNode<int> a = FindCorrespondingNode(treeNode.Left,target);
            TreeNode<int> b = FindCorrespondingNode(treeNode.Right, target);

            return a ?? b;
        }
    }
}
