using System;
using static System.Console;

namespace ardent_10_08
{
    //도전 6
    //2를 n횟수만큼곱하는것

    class MainApp
    {
        static void Main(string[] args)
        {
            string[] input = new string[5];
            int[] number = new int[5];
            WriteLine("5개의 정수 입력");
            for (int i = 0; i < 5; i++)
            {
                input[i] = ReadLine();
                number[i] = int.Parse(input[i]);
            }
            Max(number);
            Min(number);
        }
        static void Max(int[] a)
        {

            int result = a[0];
            for (int i = 0; i < 5; i++)
            {
                if(a[i]<a[i+1] || result < a[i+1])
                {
                    result = a[i + 1];
                }
                
                

            }
            WriteLine("최댓값 {0}", result);
        }
        static void Min(int[] a)
        {
            int result = a[0];
            for(int i=0; i < 5; i++)
            {
                if(a[i]>a[i+1] || result > a[i+1])
                {
                    result = a[i+1];
                }
            }
            WriteLine("최솟값 {0}", result);
        }




    }
}


