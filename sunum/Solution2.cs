public class Solution2
{
    private TreeNode prev = null;

    public bool IsValidBST(TreeNode root)
    {
        return Inorder(root);
    }
    private bool Inorder(TreeNode node)
    {
        if (node == null)
            return true;

        if (!Inorder(node.left)) 
            return false;

        if (prev != null && node.val <= prev.val)
            return false;

        prev = node;
        return Inorder(node.right);
    }
}

