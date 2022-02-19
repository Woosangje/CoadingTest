using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ardent_16Quesion03 {
    //도전3
    
    class MainApp
    {
        
        static void Main(string[] args)
        {
            int[,] board = new int[5, 5];
            int sum;
            for(int i=0; i<4; i++) {
                sum = 0;
                WriteLine("{0}번째 학생의 성적 입력 ",i+1);

                for(int j =0; j<4; j++) {
                    WriteLine("과목 {0}: ", j + 1);
                    board[i, j] = int.Parse(ReadLine());
                }
                board[i, 4] = sum;
            }
        }

        static void WriteSumBoard() {
            int sum = 0;
            
            for(int i=0; i<4; i++) {
                sum = 0;
                for (int j = 0; j < 4; j++) {
                    sum += board[j, i];
                
                }

        }
    }
}


