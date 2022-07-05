// See https://aka.ms/new-console-template for more information

using BubbleSort;
using LeetCode;

var root1 = new Bst<int>();
var root2 = new Bst<int>();

root1.Insert(1);
root1.Insert(2);
root1.Insert(4);
root2.Insert(0);
root2.Insert(1);
root2.Insert(3);


var ans = AllElementsInTwoBinarySearchTrees.GetAllElements(root1, root2).OrderBy(a=>a);

foreach (var element in ans)
{
    Console.WriteLine(element);
}

Console.ReadLine();

