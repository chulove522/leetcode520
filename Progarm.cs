using System;
using System.Text;
using firstspace;

namespace happy0520
{
    class Program
    {
        static void Main02(string[] args)
        {
            Console.WriteLine("開始執行");
            //leet520.leetcode520();
            //BinaryTreeLevel.bstLevelOrder();
            //BinaryTreeLevel.test(0);
        }
    }
}
class callmyclass
{
    public void calleveryone()
    {
        namespace01 ns01 = new namespace01();
        Console.Write(this.ToString());
        ns01.func1();
    }
}
namespace firstspace
{
    class namespace01 { 
        public void func1()
        {
            Console.WriteLine("inside first space");
        }
    }   
}
namespace secondspace
{
    class namespace01
    {
        public void func1()
        {
            Console.WriteLine("Inside second_space class可以同名喔");
        }
    }
    public class testclass
    {
        static void Main(string[] args)
        {
            firstspace.namespace01 fc = new firstspace.namespace01();
            secondspace.namespace01 sc = new secondspace.namespace01();

            fc.func1();
            sc.func1();
            Console.ReadKey();
            callmyclass cc = new callmyclass();
            cc.calleveryone();
        }
    }
}
