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

            for(int i=0; i<5; i++)
            {
                input[i] = ReadLine();
                number[i] = int.Parse(input[i]);
            }

            WriteLine("입력된 정수 중에서 최댓값" + Max(number));
            WriteLine("입력된 정수 중에서 최솟값" + Min(number));
            WriteLine("입력된 정수의 총 합" + Total(number));

        }

        static int Max(int[] a)
        {
            int result = a[0];
            for(int i=0; i<a.Length; i++)
            {
                if(result<a[i])
                {
                    result = a[i];
                }
            }
            return result;
        }
        static int Min(int[] a)
        {
            int result = a[0];
            for(int i=0; i<a.Length; i++)
            {
                if(result>a[i])
                {
                    result = a[i];
                }
            }
            return result;
        }
        static int Total(int[] a)
        {
            int result = 0;
            for(int i=0; i<a.Length; i++)
            {
                result += a[i];
            }
            return result;
        }

        


    }
    */
}


