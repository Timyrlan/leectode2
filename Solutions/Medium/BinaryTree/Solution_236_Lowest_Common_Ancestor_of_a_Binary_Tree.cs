namespace Solutions.Medium.BinaryTree;

public class Solution_236_Lowest_Common_Ancestor_of_a_Binary_Tree
{
    private TreeNode? Result { get; set; }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        Process(root, p, q);

        return Result;
    }

    private bool Process(TreeNode? node, TreeNode p, TreeNode q)
    {
        if (node == null || Result != null) return false;

        var mid = node.val == p.val || node.val == q.val ? 1 : 0;

        var left = Process(node.left, p, q) ? 1 : 0;
        var right = Process(node.right, p, q) ? 1 : 0;


        if (node == null || Result != null) return false;
        if (left + right + mid == 2) Result = node;

        return left + right + mid > 0;
    }
}