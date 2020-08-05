using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第九天代码
{
    //访问权限 默认属于:internal 程序集当中
    class person
    {
        //访问不受限 const常量不可改变
        public const int RETIREMENT = 65;
        //当前程序集或当前类
        internal string NickName;
        //当前类或派生类可访问
        protected bool isMarried;
        //只限于当前类访问
        private int age;
        //如果写默认私有 private
        string creditCarNume;
        //访问不受限
        public static void Say()
        {
            Console.WriteLine("你好,世界!");
        }
        //当前类可以使用
        private void Methold()
        {
            //可以访问当前类的所有成员字段/属性/方法
        }
    }

    public class Say
    {
        public static void Hill()
        {
            Console.WriteLine("你好,世界!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
