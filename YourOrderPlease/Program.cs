using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YourOrderPlease
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Order("is2 Thi1s T4est 3a"));
            Console.ReadKey();
        }

        public static string Order(string words)
        {
            var str = words.Split(' ');
            string result = "";
            string result1 = "";
            string result2 = "";
            string result3 = "";
            string result4 = "";
            string result5 = "";
            string result6 = "";
            string result7 = "";
            string result8 = "";
            string result9 = "";
            
            for (int i = 0; i < str.Length; i++)
            {
                var reg = Regex.Replace(str[i], "[a-zA-z]", "");
                switch (reg)
                {
                    case "1":
                        result1 = str[i];
                        break;
                    case "2":
                        result2 = str[i];
                        break;
                    case "3":
                        result3 = str[i];
                        break;
                    case "4":
                        result4 = str[i];
                        break;
                    case "5":
                        result5 = str[i];
                        break;
                    case "6":
                        result6 = str[i];
                        break;
                    case "7":
                        result7 = str[i];
                        break;
                    case "8":
                        result8 = str[i];
                        break;
                    case "9":
                        result9 = str[i];
                        break;

                    default:
                        break;
                }
            }
            result = result1 + " " + result2 + " " + result3 + " " + result4 + " " + result5 + " " + result6 + " " + result7 + " " + result8+" "  + result9;
            int a = 9 - str.Length;
            return result.Remove(result.Length - a);
        }


        public static string Order1(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }

        public static string Order2(string words)
        {
            return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));
        }

        //public static string Order3(string words)
        //{
        //    //if (words == null) return words;
        //    ////var orderedWords = words.Split(" ")
        //    //                        .OrderBy(x => Regex.Match(x, @"\d").Value);

        //    //return string.Join(" ", orderedWords);
        //}
        public static string Order4(string words)
        {
            SortedDictionary<int, string> st = new SortedDictionary<int, string>();

            string[] temp = words.Split(null);
            words = string.Empty;

            foreach (string s in temp)
            {
                foreach (char c in s)
                {
                    if (c >= '0' && c <= '9')
                    {
                        st.Add(Convert.ToInt32(c), s);
                    }
                }
            }
            foreach (KeyValuePair<int, string> p in st)
            {
                words += p.Value + " ";
            }

            return words.TrimEnd(null);
        }

        public static string Order3(string words)
        {
            return string.Join(" ", words.Split(' ').OrderBy(s => Regex.Match(s, @"\d+").Value));
        }
    }
}
