using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializeAndDeserializeBinaryTree
{
  
 // Definition for a binary tree node.
    public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
    }
 
    public class Codec
    {
        int nullValue = 1001;
        string sep = ",";
        StringBuilder result = new StringBuilder();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            queue.Clear();
            if (root == null)
            {
                return result.ToString();
            }
            queue.Enqueue(root);
            while (queue.Count > 0)
            {

                var count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    result.Append(node.val).Append(sep);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if(node.left == null && node.val != nullValue)
                    {
                        queue.Enqueue(new TreeNode(nullValue));
                    }

                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                    if(node.right == null && node.val != nullValue)
                    {
                        queue.Enqueue(new TreeNode(nullValue));
                    }


                }
            }

            return result.ToString().Substring(0, result.ToString().Length - 1);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            queue.Clear();
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }
            var list = data.Split(sep).ToList();

            var root = new TreeNode(int.Parse(list[0]));
            var temp = root;
            queue.Enqueue(temp);
            int i = 1;

            while(queue.Count > 0 && i < list.Count)
            {
                var node = queue.Dequeue();

                var left = int.Parse(list[i++]);

                if(left != nullValue)
                {
                    var leftNode = new TreeNode(left);
                    node.left = leftNode;
                    queue.Enqueue(leftNode);
                }

                var right = int.Parse(list[i++]);

                if(right != nullValue)
                {
                    var rightNode = new TreeNode(right);
                    node.right = rightNode;
                    queue.Enqueue(rightNode);
                }
            }
            return root;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Codec c = new Codec();
            TreeNode root = new TreeNode(1);
            TreeNode left = new TreeNode(2);
            TreeNode right = new TreeNode(3);
            root.left = left;
            left.right = right;
            var serialized = c.serialize(root);
            var retree = c.deserialize(serialized);
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec ser = new Codec();
    // Codec deser = new Codec();
    // TreeNode ans = deser.deserialize(ser.serialize(root));
}
