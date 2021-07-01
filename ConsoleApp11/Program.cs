using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        int task1_max(int[] m)
        {
            int res = 0;
            int max = m.Max();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == max)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        int task1_min(int[] m)
        {
            int res = 0;
            int min = m.Min();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == min)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        void task1()
        {
            Random r = new Random();
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = r.Next(50);
            }
            int max = mas.Max();
            int min = mas.Min();
            mas[task1_max(mas)] = min;
            mas[task1_min(mas)] = max;
        }
        int task2_min(int[] m)
        {
            int res = 0;
            int min = m.Min();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == min)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        void task2()
        {
            Random r = new Random();
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = r.Next(50);
            }
            int[] mas1 = new int[9];
            int min = mas.Min();
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (mas[i] != min)
                {
                    mas1[j] = mas[i];
                    j++;
                }
            }
            mas = mas1;
        }
        int task3_min(int[] m)
        {
            int res = 0;
            int min = m.Min();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == min)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        void task3()
        {
            Random r = new Random();
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = r.Next(100) + 50;
            }
            int[] mas1 = new int[11];
            int max = mas.Max();
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (mas[i - 1] == max)
                {
                    mas1[j] = mas[i];
                }
                j++;
            }
            for (int i = 0; i < 10; i++)
            {
                mas[i] = mas1[i];
            }
        }
        void task4()
        {
            Random r = new Random();
            int[][] sport = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                sport[i] = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    sport[i][j] = r.Next(10);
                }
            }
            int[] sum = new int[5];
            for (int i = 0; i < 5; i++)
            {
                sum[i] = sport[i].Sum();
            }
            int max = sum.Max();
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                if (max == sum[i])
                {
                    res = i + 1;
                }
            }
            Console.WriteLine("Максимальный результат был в " + res + " пятеборье");
        }
        void task5()
        {
            Random r = new Random();
            int[][] sport = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                sport[i] = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    sport[i][j] = r.Next(10);
                }
            }
            for (int i = 0; i < 5;)
            {
                int max = sport[i].Max();
                for (int j = 0; j < 10; j++)
                {
                    if (max == sport[i][j])
                    {
                        int res = j + 1;
                        Console.WriteLine("Максимальный результат в " + i + " пятеборье был " + res + " ученик");
                    }
                }

            }

        }
        void task6()
        {
            Random r = new Random();
            int[][] exam = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                exam[i] = new int[15];
                for (int j = 0; j < 15; j++)
                {
                    exam[i][j] = r.Next(5);
                }
            }
            int[] sum = new int[3];
            for (int i = 0; i < 3; i++)
            {
                sum[i] = exam[i].Sum();
            }
            int max = sum.Max();
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                if (max == sum[i])
                {
                    res = i + 1;
                }
            }
            Console.WriteLine("Максимальный результат был в " + res + " экзамене");
        }
        void task7()
        {
            string line = Console.ReadLine();
            int len = line.Length / 2;
            string text = line.Substring(len);
            string text1 = "";
            string eng = "";
            string ENG = "";
            for (int i = 97; i < 123; i++)
            {
                eng += (char)i;
            }
            for (int i = 65; i < 89; i++)
            {
                ENG += (char)i;
            }
            for (int i = 0; i < len; i++)
            {
                if (eng.Contains(text[i]))
                {
                    text1 += ENG[eng.IndexOf(text[i])];
                }
                else
                {
                    text1 += text[i];
                }
            }
            text = line.Substring(len, line.Length);
            string text2 = "";
            for (int i = len; i < line.Length; i++)
            {
                if (ENG.Contains(text[i]))
                {
                    text2 += eng[ENG.IndexOf(text[i])];
                }
                else
                {
                    text2 += text[i];
                }
            }
            Console.WriteLine(text1 + text2);
        }

        static void Main(string[] args)
        {
        }
    }
}
