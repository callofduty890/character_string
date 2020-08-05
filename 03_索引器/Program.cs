using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_索引器
{
    class TempRecord
    {
        //温度数组初始化数组
        public double[] temps = new double[5] { 20.5, 31.4, 15.5, 19.7, 30 };

        //索引器
        public double this[int index]
        {
            //返回指定索引所对应的元素数组
            get { return temps[index]; }
            //设置指定索引所对应的数组元素的值
            set { temps[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TempRecord temp = new TempRecord();
            Console.WriteLine(temp.temps[0]);
            Console.WriteLine(temp.temps[1]);
            Console.WriteLine("=================");
            //使用索引器进行访问数组变量的值
            Console.WriteLine(temp[0]);
            Console.WriteLine(temp[1]);
            Console.ReadKey();

        }
    }
}
