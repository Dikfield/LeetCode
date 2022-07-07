// See https://aka.ms/new-console-template for more information

using BubbleSort;
using LeetCode;

var root1 = new TreeNode<int>(10);

root1.Insert(4);
root1.Insert(6);



var ans = RootEqualsSumOfChildren.CheckTree(root1);

if(ans == true)
    Console.WriteLine("certo");
else
    Console.WriteLine("errado");


Console.ReadLine();

