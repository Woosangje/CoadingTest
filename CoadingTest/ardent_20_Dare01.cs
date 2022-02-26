using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ardent_20_Dare01 {
    //도전1
    
    class MainApp {
        //90도로 돌려서 출력하기
        static void Main(string[] args) {

            int[,] board = new int[4, 4]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 10, 11, 12 },
                {13, 14, 15, 16 }
            };
            int[,] boardB = new int[4, 4];
            int len = 4;
            int temp;
            for(int i=0; i < len; i++) {

                for(int j=0; j<len; j++) {
                   
                    boardB[j, len - 1 - i] = board[i, j];
                }
                WriteLine();
            }

            for(int i=0; i<len; i++) {
                for(int j=0; j<len; j++) {
                    Write("{0}, ", boardB[i, j]);
                }
                WriteLine();
            }

        }

    }
}


