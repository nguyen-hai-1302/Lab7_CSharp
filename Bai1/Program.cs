using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            List<int> nums = new List<int>() { 1, 3, 4, 5, 8, 9 };
            string str = "chao mung den voi binh nguyen vo tan";
            string st = "CHAO mung DEN Voi binh nguyen vo tan";
            string[] words = st.Split(' ');
            //
            var binhphuong = from bp in nums
                             where bp > 4
                             select bp;
            //
            var chu = str.Where(Char.IsLetter).GroupBy(x => x).Select(group => new {Key = group.Key, count = group.Count()}).OrderBy(y => y.Key);
            //
            var hoa = from x in words
                      where x.Equals(x.ToUpper())
                      select x;
            //
            Console.WriteLine("Bai 1:");
            Console.WriteLine("Bai 1a:");
            foreach (var item in binhphuong)
            {
                Console.WriteLine("Binh phuong so {0} = {1}", item, item * item);
            }
            //
            Console.WriteLine("Bai 1b:");
            foreach(var item in chu)
            {
                Console.WriteLine(item + " ");
            }
            //            
            Console.WriteLine("Bai 1c:");
            foreach (var item in hoa)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine();
        }
    }
}
