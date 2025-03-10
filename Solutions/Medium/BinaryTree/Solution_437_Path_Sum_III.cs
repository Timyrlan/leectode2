namespace Solutions.Medium.BinaryTree;

public class Solution_437_Path_Sum_III
{
    private readonly Dictionary<long, int> dic = new();
    private readonly Stack<Tuple<TreeNode, long>> stack = new();
    private int countArrays;
    private int TargetSum;

    public int PathSum(TreeNode root, int targetSum)
    {
        if (root == null) return 0;

        //if (root.left == null && root.right == null)
        //{
        //    return targetSum == root.val ? 1 : 0;
        //}

        TargetSum = targetSum;

        //dic.Add(0, 1);

        ProcessNode(0, root);

        while (stack.Any())
        {
            var node = stack.Peek();

            if (node.Item1.left != null)
            {
                ProcessNode(node.Item2, node.Item1.left);
                node.Item1.left = null;
            }
            else if (node.Item1.right != null)
            {
                ProcessNode(node.Item2, node.Item1.right);
                node.Item1.right = null;
            }
            else if (node.Item1.left == null && node.Item1.right == null)
            {
                node = stack.Pop();
                dic[node.Item2]--;
            }
        }

        return countArrays;
    }

    private void ProcessNode(long prevSum, TreeNode node)
    {
        var sum = prevSum + node.val;

        var dif = sum - TargetSum;

        if (sum == TargetSum) 
            countArrays++;

        if (dic.TryGetValue(dif, out var countEntries)) 
            countArrays += countEntries;

        if (!dic.TryAdd(sum, 1)) dic[sum]++;

        stack.Push(new Tuple<TreeNode, long>(node, sum));
    }
}