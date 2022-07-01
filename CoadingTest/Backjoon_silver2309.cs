using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using static System.Console;
namespace Backjoon_silver2309 {

    /*
    class MainApp {


        static void Main(string[] args) {

            int[] tall = new int[9];
            int len = 9;
            List<int> result = new List<int>();
            int total = 0;
            for (int i = 0; i < tall.Length; i++) {

                Console.Write("{0} 번째 난쟁이의 키" , i + 1);

                tall[i] = int.Parse(ReadLine());
                if (tall[i] < 0 || tall[i] > 100) {

                    WriteLine("입력오류 ");
                    i--;
                }
            }
            for (int i = 0; i < 9; i++) {
                total += tall[i];
            }


            //2명 제외하기
            for (int i = 0; i < len-1; i++) {

                for (int j = i+1; j < len; j++) {

                    if (total - (tall[i] + tall[j]) == 100) {
                      
                        for(int k=0; k<len; k++) {

                            if(k != i && k != j) {
                                result.Add(tall[k]);
                                
                            }
                        }
                        break;
                    }
                }

            }
            //버블정렬
            for (int i = 0; i < result.Count; i++) {

                for (int j = 0; j < result.Count-1; j++) {

                    if (result[j] >result[j + 1]) {

                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }

                }
            }
            for (int i = 0; i < result.Count; i++) {

                WriteLine(result[i]);
            }


        }
       



    }*/
}