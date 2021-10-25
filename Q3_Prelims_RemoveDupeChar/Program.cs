using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Prelims_RemoveDupeChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter string here: ");
            //string text = Console.ReadLine();

            string text = "The name is Cuttack whcich is near the Capital of State Odisha";

            string[] substring = text.Split(' ');

            for (int i =0; i< substring.Length; i++)
            {
                string temp = substring[i];
                string result = "";

                foreach (char value in temp)
                {
                    if (result.IndexOf(value) == -1)
                    {
                        result += value;
                    }
                }
                substring[i] = result;
            }

            for (int i = 0; i < substring.Length; i++)
            {
                Console.Write(substring[i] + " ");
            }


            Console.ReadLine();
        }
    }
}
