using System;

namespace HW.Arrays
{

    class Program
    {
//        static void Main()
//        {
//            int N = 5;
//            int M = 6;

//            int[,] array = new int[N, M];
//            int counter = 1;

//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < M; j++)
//                {
//                    array[i, j] = counter++;
//                }
//            }

//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < M; j++)
//                {
//                    Console.Write(array[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int[] arr = { 1, 11, 21, 1211, 111221, 312211, 13112221 };
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}



