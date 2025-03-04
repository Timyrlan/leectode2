namespace Solutions.Easy.BinaryTree;

public class Test
{
    [Test]
    public void Solution_1207_Unique_Number_of_Occurrences()
    {
        var node = new TreeNode(3)
        {
            left = new TreeNode(9),
            right = new TreeNode(20, new TreeNode(15), new TreeNode(7))
        };
        Assert.That(new Solution_104_Maximum_Depth_of_Binary_Tree().MaxDepth(node), Is.EqualTo(3));
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