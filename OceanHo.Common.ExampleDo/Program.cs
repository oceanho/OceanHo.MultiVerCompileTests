using System;
using System.Collections.Generic;
using System.Text;

namespace OceanHo.Common.ExampleDo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add("0");
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");

            list.Add("fuck");       // 蹦 ~_~

            // 尝试执行转换（默认转换方法，最后一个转换失败，您可以去掉注释，试试看咯。）
            // IList<int> intList = list.AsTDigit<int>(); 

            IList<int> intList2 = list.AsTDigit<int>(MyConvertHandler);

            foreach (int item in intList2)
            {
                Console.WriteLine("", item);
                Console.WriteLine("Convert Result AsTDigit Is : {0}", item);
            }
            Console.ReadLine();
        }

        static int MyConvertHandler(object obj)
        {
            try
            {
                return ObjectExtension.AsT<int>(obj);
            }
            catch
            {
                return -1;
            }
        }
    }
}
