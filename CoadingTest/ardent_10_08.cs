using System;
using static System.Console;

namespace ardent_10_08
{
    //도전 6

   class MainApp
     {
         static void Main(string[] args)
         {
             WriteLine("정수 입력");
             string input = ReadLine();
             int n = int.Parse(input);
             int k = 0;//최댓값
             for (int i = 2; i < n; i++)
             {
                 if (n / i == 0)//256/8은0이되서 최대값
                 {
                     k = i;
                 }
             }
             WriteLine("2의 {0}승은 {1}", n, k );

         }

     }
}


