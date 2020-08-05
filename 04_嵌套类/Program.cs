using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_嵌套类
{
    class Container
    {
        //嵌套类
        public class Nested
        {
            //嵌套类的方法
            public void SayHello()
            {
                Console.WriteLine("Hello ,I am a nested class!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Container.Nested nested = new Container.Nested();
            nested.SayHello();
            Console.ReadKey();
        }
    }
}
