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


    [Test]
    public void Solution_872_Leaf_Similar_Trees()
    {
        var node1 = new TreeNode(3)
        {
            left = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                }
            },
            right = new TreeNode(1, new TreeNode(9), new TreeNode(8))
        };

        var node2 = new TreeNode(3)
        {
            left = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(7)
            },
            right = new TreeNode(1, new TreeNode(4), new TreeNode(2, new TreeNode(9), new TreeNode(8)))
        };

        Assert.That(new Solution_872_Leaf_Similar_Trees().LeafSimilar(node1, node2), Is.EqualTo(true));
    }

    [Test]
    public void Solution_872_Leaf_Similar_Trees2()
    {
        var node1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var node2 = new TreeNode(1, new TreeNode(3), new TreeNode(2));


        Assert.That(new Solution_872_Leaf_Similar_Trees().LeafSimilar(node1, node2), Is.EqualTo(false));
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