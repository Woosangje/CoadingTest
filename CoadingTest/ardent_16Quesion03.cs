using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ardent_16Quesion03 {
    //도전3
/*
    class MainApp {

        public static int[,] record = new int[5,5];
        static void WriteRecord() {

            for(int i=0; i<4; i++) {

                Write("국영수사점수입력");
                for (int j=0; j<4; j++) {

                    
                    record[i, j] = int.Parse(ReadLine());
                }
            }


        }

        static void WriteSumRecord() {

            for (int i = 0; i < 4; i++) {

                Write("국영수사점수입력");
                for (int j = 0; j < 4; j++) {

                    record[i, 4] += record[i, j];
                    record[4, i] += record[j, i];
                }
            }
        }

        static void ShowAllRecord() {

            WriteLine("    국어  영어  수학  국사  총점");
            for (int i = 0; i < 5; i++) {

                switch(i){

                    case 0:
                        Write("철희");
                        break;
                    case 1:
                        Write("철수");
                        break;
                    case 2:
                        Write("영희");
                        break;
                    case 3:
                        Write("영수");
                        break;
                    case 4:
                        Write("총점");
                        break;
                }
                for (int j = 0; j < 5; j++) {

                    Write(record[i, j] + " ");
                    
                }
                Write("\n");
            }
        }

        static void Main(string[] args) {
            WriteRecord();
            WriteSumRecord();
            ShowAllRecord();



        }



    }
*/

}


