using System;

namespace Task9
{
    class Program
    {
        static void InputManually(int[] mas, int N)
        {
            for (int i = 0; i <N; i++)
            {
                Console.WriteLine($"Введите {i}-элемент массива");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Print(int[] mas, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        static int CountPos(int[] mas)
        {
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0) count++;
            }
            return count;
        }
        static int CountNeg(int[] mas)
        {
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0) count++;
            }
            return count;
        }
        static int CountZero(int[] mas)
        {
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == 0) count++;
            }
            return count;
        }
        static int[] Sort(int[] mas, int N)
        {
            int pos = CountPos(mas);
            int neg = CountNeg(mas);
            int zero = CountZero(mas);
            int[] positives = new int[pos];
            int p = 0;
            int[] negatives = new int[neg];
            int n = 0;
            int[] zeros = new int[zero];
            int z = 0;
            int[] temp = new int[N];
            int j = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    positives[p] = mas[i];
                    p++;
                }
                if(mas[i]<0)
                {
                     negatives[n] = mas[i];
                     n++;
                }
                if(mas[i]==0)
                {
                    zeros[z] = mas[i];
                    z++;
                }
            }
            for (int i = 0; i < positives.Length; i++)
            {
                temp[j] = positives[i];
                j++;
            }
            for (int i = 0; i < zeros.Length; i++)
            {
                temp[j] = zeros[i];
                j++;
            }
            for (int i = 0; i < negatives.Length; i++)
            {
                temp[j] = negatives[i];
                j++;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            Console.WriteLine("Заполнение массива:");
            InputManually(mas, N);
            Print(mas, N);
            mas = Sort(mas, N);
            Console.WriteLine("Отсортированный массив:");
            Print(mas, N);
        }
    }
}
