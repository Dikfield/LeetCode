// See https://aka.ms/new-console-template for more information

using BubbleSort;
using LeetCode;

var treeNode = new TreeNode<int>(7);

treeNode.Insert(4);
treeNode.Insert(3);
treeNode.Insert(6);
treeNode.Insert(19);

Console.WriteLine(treeNode.Min());

Console.WriteLine(treeNode.Max());



var ans = FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree.FindCorrespondingNode(treeNode, 3);

Console.WriteLine(ans.Value);

