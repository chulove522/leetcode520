using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy0520
{
    class BinaryTreeLevel
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                    this.val = val;
                    this.left = left;
                    this.right = right;
             }
        }
        public static IList<IList<int>> bstLevelOrder()
        {
            TreeNode root = new TreeNode();
            TreeNode front = new TreeNode();
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
                    return list;

            //levelOrder(list, root, 0);
            //return list;

            Queue<TreeNode> myq = new Queue<TreeNode>();
            myq.Enqueue(root);

            int nodeCount = 1;
            while (myq.Count != 0)
            {
                front = myq.Dequeue();
                nodeCount++;
                double level = Math.Log(nodeCount, 2) - 1;
                if (level >= list.Count || list.Count ==0)
                    list.Add(new List<int>());
                list[(int)level].Add(front.val);

                if (front.left != null)
                    myq.Enqueue(front.left);
                if (front.left != null)
                    myq.Enqueue(front.right);
            }

            return list;
                
        }
        public static void levelOrder(IList<IList<int>> ans, TreeNode t, int level)
        {
            if (t == null)
                return;
            if (level >= ans.Count)
                ans.Add(new List<int>());
            ans[level].Add( t.val);
            levelOrder(ans, t.left, level+1);
            levelOrder(ans, t.right, level+1);
        }

        public static void test(int i) {
            //int 
            //if(i<10)
            //    test(i++);
            Console.WriteLine(++i);
            Console.WriteLine(i);

        }
    }
   
        
}
