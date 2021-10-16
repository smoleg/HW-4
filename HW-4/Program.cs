using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four",4},
                {"two",2},
                {"one",1},
                {"three",3},
            };
            var d = dict.OrderBy(pair => pair.Value);
            foreach (var pair in d)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }


            Console.WriteLine();
            List<int> list = new List<int>();
            int[] arr = new int[] { 1, 5, 34, 3, 87, 3, 45, 2, 34, 1, 1, 34 };
            list.AddRange(arr);

            var list2 = list.GroupBy(e => e);

            var list3 = from item in list
                        group item by item into gr
                        select new { gr.Key, Count = gr.Count() };

            foreach (var item in list2)
            {
                Console.WriteLine($"Элемент \"{item.Key}\" встречается {item.Count()} раз");
            }
            Console.WriteLine();

            foreach (var item in list3)
            {
                Console.WriteLine($"Элемент \"{item.Key}\" встречается {item.Count} раз");
            }           

            Console.ReadLine();
        }
    }
}
