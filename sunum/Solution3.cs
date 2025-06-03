public class Solution3
{
    public bool IsValidBST(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        TreeNode prev = null;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            if (prev != null && current.val <= prev.val)
                return false;

            prev = current;
            current = current.right;
        }

        return true;
    }
}

