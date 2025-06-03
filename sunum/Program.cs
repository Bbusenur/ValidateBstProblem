class Program
{
    static void Main()
    {

        var solution = new Solution1();

        TreeNode tree1 = new TreeNode(5,
            new TreeNode(2),
            new TreeNode(7)
        );
        //      5
        //     / \
        //    2   7

        TreeNode tree2 = new TreeNode(8,
            new TreeNode(3),
            new TreeNode(10,
                null,
                new TreeNode(14,
                    new TreeNode(9),
                    null
                )
            )
        );
        //    8
        //   / \
        //  3   10
        //        \
        //         14
        //         /
        //       9

        TreeNode tree3 = new TreeNode(8,
            new TreeNode(3),
            new TreeNode(8)
        );
        //    8
        //   / \
        //  3   8

        Console.WriteLine(solution.IsValidBST(tree1));
        Console.WriteLine(solution.IsValidBST(tree2));
        Console.WriteLine(solution.IsValidBST(tree3));


    }
}




