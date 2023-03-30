using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_2_8
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
         static int[] SortArray(int[] result)
        {
            for (int j = 0; j < result.Length; j++)
            {
                for (int k = j + 1; k < result.Length; k++)
                {
                    if (result[j] > result[k])
                    {
                        int number = result[k];
                        result[k] = result[j];
                        result[j] = number;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
            return result;
        }

         static void Main(string[] args)
        {
            var result = GetArrayFromConsole();
            SortArray(result);
        }
    }
}
