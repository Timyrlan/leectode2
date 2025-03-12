namespace Solutions.Medium.BinaryTree;

public class Solution_1372_Longest_ZigZag_Path_in_a_Binary_Tree
{
    private int MaxDeep { get; set; }

    public int LongestZigZag(TreeNode root)
    {
        if (root == null || (root.left == null && root.right == null)) return 0;

        Process(root, -1);

        return MaxDeep;
    }

    private void Process(TreeNode node, int currentDeep, bool? left = null)
    {
        currentDeep += 1;

        MaxDeep = MaxDeep > currentDeep ? MaxDeep : currentDeep;

        if (node.left != null) Process(node.left, left == true ? 0 : currentDeep, true);
        if (node.right != null) Process(node.right, left == false ? 0 : currentDeep, false);
    }
}