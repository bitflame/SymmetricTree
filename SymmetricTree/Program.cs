using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            //Balanced Tree Sample
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(2);
            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(4);
            //root.right.left = new TreeNode(4);
            //root.right.right = new TreeNode(3);
            //Unbalanced tree sample 
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.right = new TreeNode(3);
            root.right.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(root));
            Console.ReadLine();
        }
        private static Boolean IsSymmetric (TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return IsMirror(root.left, root.right);
        }
        private static Boolean IsMirror(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode == null && rightNode == null)
            {
                return true;
            }
            if (leftNode == null || rightNode == null)
            {
                return false;
            }
            if (leftNode.val != rightNode.val)
            {
                return false;
            }
            //if (leftNode.left != rightNode.right && leftNode.right != rightNode.left)
            return (leftNode.val == rightNode.val && IsMirror(leftNode.left, rightNode.right) && IsMirror(rightNode.left, leftNode.right));
        } 
    }
}
