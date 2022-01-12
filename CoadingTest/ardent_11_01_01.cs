using System;
using static System.Console;
using System.Linq;

namespace ardent_11_01_01
{
    //11-1
    /*
    class MainApp
    {

        static void Main(string[] args)
        {
            WriteLine("정수 5개 입력");
            string[] input = Enumerable.Repeat(" ", 5).ToArray();
            int[] number = Enumerable.Repeat(0, 5).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = ReadLine();
                number[i] = int.Parse(input[i]);
            }

            WriteLine("입력된 정수 중에서 최댓값: "+Max(number));
            WriteLine("입력된 정수 중에서 최솟값: "+Min(number));
            WriteLine("입력된 정수의 총 합 " +Total(number));

        }

        static int Max(int[] arr)
        {
            int result = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (result < arr[i])
                {
                    result = arr[i];
                }

            }
            return result;
        }
        static int Min(int[] arr)
        {
            int result = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (result > arr[i])
                {
                    result = arr[i];
                }
            }
            return result;

        }

        static int Total(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];

            }
            return result;
        }


    }*/

}


