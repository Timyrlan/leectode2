namespace Solutions.Medium.BinaryTree;

public class Test
{
    [Test]
    public void Solution_872_Leaf_Similar_Trees2()
    {
        var node1 = new TreeNode(3, new TreeNode(1, new TreeNode(3)), new TreeNode(4, new TreeNode(1), new TreeNode(5)));


        Assert.That(new Solution_1448_Count_Good_Nodes_in_Binary_Tree().GoodNodes(node1), Is.EqualTo(4));
    }


    [Test]
    public void Solution_437_Path_Sum_III()
    {
        var targetSum = 8;
        var node1 = new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(3), new TreeNode(-2)), new TreeNode(2, new TreeNode(1))),
            new TreeNode(-3, new TreeNode(11))
        );


        Assert.That(new Solution_437_Path_Sum_III().PathSum(node1, targetSum), Is.EqualTo(3));
    }

    [Test]
    public void Solution_437_Path_Sum_III_2()
    {
        var targetSum = 22;
        var node1 = new TreeNode(5,
            new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))),
            new TreeNode(8, new TreeNode(13), new TreeNode(4, new TreeNode(5), new TreeNode(1)))
        );


        Assert.That(new Solution_437_Path_Sum_III().PathSum(node1, targetSum), Is.EqualTo(3));
    }

    [Test]
    public void Solution_437_Path_Sum_III_3()
    {
        var targetSum = 0;
        var node1 = new TreeNode(1);


        Assert.That(new Solution_437_Path_Sum_III().PathSum(node1, targetSum), Is.EqualTo(0));
    }


    [Test]
    public void Solution_437_Path_Sum_III_4()
    {
        var targetSum = 0;
        var node1 = new TreeNode(1, new TreeNode(2));


        Assert.That(new Solution_437_Path_Sum_III().PathSum(node1, targetSum), Is.EqualTo(0));
    }


    [Test]
    public void Solution_437_Path_Sum_III_5()
    {
        var targetSum = 1;
        var node1 = new TreeNode(0, new TreeNode(1), new TreeNode(1));


        Assert.That(new Solution_437_Path_Sum_III().PathSum(node1, targetSum), Is.EqualTo(4));
    }


    [Test]
    public void Solution_437_Path_Sum_III_6()
    {
        var targetSum = 0;
        var node1 = new TreeNode(1000000000, new TreeNode(1000000000,new TreeNode(294967296, new TreeNode(1000000000, new TreeNode(1000000000, new TreeNode(1000000000))))));


        Assert.That(new Solution_437_Path_Sum_III().PathSum(node1, targetSum), Is.EqualTo(0));
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