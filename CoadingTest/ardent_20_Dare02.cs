using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ardent_20_Dare01 {
    //도전1 달팽이 배열
    /*
    class MainApp {
        
        static void Main(string[] args) {

            WriteLine("배열의 길이 n입력");
            int n = int.Parse(ReadLine());

            int[,] board = new int[n, n];
            int i=0, j=0;
            int value = 1;
            for(i=0; i<n; i++) {//배열의 시작과 끝을 생략
                
                for(j=i; j<n-i; j++) {
                    board[i, j] = value++;
                }
                for(j=i+1; j<n-i; j++) { 
                    board[j, n-i-1] = value++;
                }
                for(j=n-1-i; j>i; j--) {
                    board[n - i - 1, j-1] = value++;
                }
                for(j=i; j<n-2-i; j++) {
                    board[n - j-2, i] = value++;
                }
            }

            for(i=0; i<n; i++) {

                for(j=0; j<n; j++) {

                    if(board[i, j] <10)
                    Write(" {0}, ",board[i, j]);
                    else {
                    Write("{0}, ", board[i, j]);
                    }
                }
                WriteLine();
            }
        }

    }*/
}


