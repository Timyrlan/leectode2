namespace Solutions.Easy.BinaryTree;

public class Solution_872_Leaf_Similar_Trees
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null) return true;
        if (root1 == null || root2 == null) return false;

        var a = GetLeaves(root1);
        var b = GetLeaves(root2);
        return a.SequenceEqual(b);
    }

    private List<int> GetLeaves(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var result = new List<int>();

        stack.Push(root);


        while (stack.Count != 0)
        {
            var node = stack.Pop();

            if (node.left != null) stack.Push(node.left);

            if (node.right != null) stack.Push(node.right);

            if (node.left == null && node.right == null) result.Add(node.val);
        }


        return result;
    }
}