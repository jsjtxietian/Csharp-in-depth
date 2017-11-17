using System;
using System.Collections.Generic;

namespace Csharp_in_depth
{
    class Chap3
    {
#region P60
        public static void SimpleGeneric()
        {
            List<int> IntList = new List<int>();

            IntList.Add(1);
            IntList.Add(2);
            IntList.Add(3);
            IntList.Add(4);
            IntList.Add(5);

            Converter<int, double> converter = TaskSquareRoot;
            List<double> doubles;
            doubles = IntList.ConvertAll(converter);
            doubles.ForEach(Console.WriteLine);

        }

        static double TaskSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
#endregion

#region P61-3.3

        static List<T> MakeList<T>(T first, T second)
        {
            List<T> list = new List<T>();
            list.Add(first);
            list.Add(second);
            return list;
        }

        


#endregion




    }
}
