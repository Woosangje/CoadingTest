using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace ardent_15_Dare02
{
    //도전2
    
    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("문자열 입력: ");
            char[] voca= ReadLine().ToCharArray();
            int len = voca.Length-1;
            for(int i=0; i<len/2; i++)
            {
                if (char.Compare(voca[i], voca[len - 1 - i], false))

            }

        }

    }
}


