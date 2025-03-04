namespace Solutions.Easy.BinaryTree;

public class Solution_104_Maximum_Depth_of_Binary_Tree
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        var stack = new Stack<TreeNode>();
        var max = 0;

        var current = root;
        TreeNode? last = null;

        while (current != null)
        {
            max = max < stack.Count ? stack.Count : max;

            if (last != null && last == current.right)
            {
                last = current;
                stack.TryPop(out current);
            }
            else if (current.left != null && last != current.left)
            {
                stack.Push(current);
                current = current.left;
            }
            else if (current.right != null && last != current.right)
            {
                stack.Push(current);
                current = current.right;
            }
            else
            {
                last = current;
                stack.TryPop(out current);
            }
        }

        return max + 1;
    }
}