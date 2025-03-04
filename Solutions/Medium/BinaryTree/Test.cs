namespace Solutions.Medium.BinaryTree;

public class Test
{
    [Test]
    public void Solution_872_Leaf_Similar_Trees2()
    {
        var node1 = new TreeNode(3, new TreeNode(1, new TreeNode(3)), new TreeNode(4, new TreeNode(1), new TreeNode(5)));


        Assert.That(new Solution_1448_Count_Good_Nodes_in_Binary_Tree().GoodNodes(node1), Is.EqualTo(4));
    }
}

/// <summary>
///     Definition for a binary tree node.
/// </summary>
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public TreeNode? left = left;
    public TreeNode? right = right;
    public int val = val;
}