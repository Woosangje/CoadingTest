using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using static System.Console;
namespace Backjoon_silver4344 {
    /*
    class MainApp {

        static void Main(string[] args) {


            int[][] score = new int[5][];
            score[0] = new int[5] { 50, 50, 70, 80, 100 };
            score[1] = new int[7] { 100, 95, 90, 80, 70, 60, 50 };
            score[2] = new int[3] { 70, 90, 80 };
            score[3] = new int[3] { 70, 90, 81 };
            score[4] = new int[9] { 100, 99, 98, 97, 96, 95, 94, 93, 91 };

            float[] sum = new float[5];
            float[] sum2 = new float[5];
            for (int i = 0; i < score.GetLength(0); i++) {

                for (int j = 0; j < score[i].Length; j++) {

                    sum[i] += score[i][j];
                }

                sum[i] /= score[i].Length;
            }

            //평균이상 학생 을 백분율로 나누기
            for (int i = 0; i < score.GetLength(0); i++) {

                int over = 0;
                for (int j = 0; j < score[i].Length; j++) {

                    if (sum[i] < score[i][j]) {

                        over++;
                    }
                }
                sum2[i] = ((float)over / (float)score[i].Length) * 100;//(float)선언이 중요
            }



            for (int i = 0; i < score.GetLength(0); i++) {

                WriteLine("{0:F3}%", sum2[i]);
            }

        }

    }
    */
}