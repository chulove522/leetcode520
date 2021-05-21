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

            #region#
            TreeNode root = new TreeNode();
            root.val = 1;
            TreeNode t2 = new TreeNode();
            TreeNode t3 = new TreeNode();
            TreeNode t4 = new TreeNode();
            TreeNode t5 = new TreeNode();
            t2.val = 2;
            t3.val = 3;
            t4.val = 4;
            t5.val = 5;
            root.left = t2;
            root.right = t3;
            t2.left = t4;
            t2.right = t5;
            #endregion

            TreeNode front = new TreeNode();
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
                    return list;

            //levelOrder(list, root, 0);
            //return list;

            Queue<TreeNode> myq = new Queue<TreeNode>();
            myq.Enqueue(root);
            while (myq.Count != 0)
            {
                int nodeCount = myq.Count();
                List<int> sublist = new List<int>();

                while (nodeCount > 0) {

                    front = myq.Dequeue();  //root
                    sublist.Add(front.val);

                    if (front.left != null)
                        myq.Enqueue(front.left);
                    if (front.right != null)
                        myq.Enqueue(front.right);

                    nodeCount--;
                }
                list.Add(sublist);
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
