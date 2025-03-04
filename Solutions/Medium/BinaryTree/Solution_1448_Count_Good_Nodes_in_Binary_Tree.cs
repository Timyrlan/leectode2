namespace Solutions.Medium.BinaryTree;

public class Solution_1448_Count_Good_Nodes_in_Binary_Tree
{
    public int GoodNodes(TreeNode root)
    {
        var stack = new Stack<Tuple<TreeNode, int>>();
        var count = 1;

        stack.Push(new Tuple<TreeNode, int>(root, root.val));
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (node.Item1.left != null)
            {
                var max = node.Item2;

                if (max <= node.Item1.left.val)
                {
                    count++;
                    max = node.Item1.left.val;
                }

                stack.Push(new Tuple<TreeNode, int>(node.Item1.left, max));
            }

            if (node.Item1.right != null)
            {
                var max = node.Item2;

                if (max <= node.Item1.right.val)
                {
                    count++;
                    max = node.Item1.right.val;
                }

                stack.Push(new Tuple<TreeNode, int>(node.Item1.right, max));
            }
        }

        return count;
    }
}