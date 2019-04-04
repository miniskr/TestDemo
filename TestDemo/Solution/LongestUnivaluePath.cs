using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Solution
{
    public class LongestUnivaluePath
    {
        int ans;
        public int LongestUnivaluePathNode(TreeNode root)
        {
            ans = 0;
            ArrowLength(root);
            return ans;
        }


        private int ArrowLength(TreeNode node)
        {
            if (node == null) return 0;
            var left = ArrowLength(node.left);
            var right = ArrowLength(node.right);
            var arrowLeft = 0;
            var arrowRight = 0;
            if (node.left != null && node.left.val == node.val)
            {
                arrowLeft += left + 1;
            }
            if (node.right != null && node.right.val == node.val)
            {
                arrowRight += right + 1;
            }

            ans = Math.Max(ans, arrowLeft + arrowRight);
            return Math.Max(arrowRight, arrowLeft);
        }   
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
