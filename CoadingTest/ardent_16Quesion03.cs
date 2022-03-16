using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ardent_16Quesion03 {
    //도전3

    /*class MainApp {
        public static int[,] record = new int[5, 5];
        static void WriteRecord() {

            int sum;
            for (int i = 0; i < 4; i++) {
                sum = 0;
                WriteLine("{0}번째 학생의 성적 입력 ", i + 1);

                for (int j = 0; j < 4; j++) {
                    Write("과목 {0}: ", j + 1);
                    record[i, j] = int.Parse(ReadLine());
                }
                record[i, 4] = sum;
            }
        }

        static void WriteSumRecord() {
            int sumA = 0;//과목별 성적 합계
            int sumB = 0;//학생별 성적 합계
            int i, j;

            for (i = 0; i < 4; i++) {
                sumA = 0;
                sumB = 0;
                for (j = 0; j < 4; j++) {
                    sumA += record[j, i];
                    sumB += record[i, j];
                }

                record[4, i] = sumA;
                record[i, 4] = sumB;
                record[4, 4] += sumA;
            }

        }

        static void ShowAllRecord() {
            int i, j;
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 5; j++) {
                    Write("{0} ", record[i, j]);
                }
                WriteLine();
            }
        }

        static void Main(string[] args) {
            WriteRecord();
            WriteSumRecord();
            ShowAllRecord();



        }



    }*/


}


