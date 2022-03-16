using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ardent_15_Dare05_BubbleSort2 {
    //도전2



    /*
    class MainApp {
        static void Main(string[] args) {

            WriteLine("숫자입력");
            int[] arr = new int[7];
            int len = arr.Length;
            for(int i=0; i<len; i++) {
                arr[i] = int.Parse(ReadLine());
            }
            DesSort(ref arr, len);

            foreach (int c in arr) {
                Write(c + " ");
            }
            WriteLine();
        }

        static public void DesSort(ref int[] ary, int len) {

            int temp = 0;
            for(int i=0; i<len-1; i++) {
                
                for(int j=0; j<len-i-1; j++) {
                    
                    if(ary[j] < ary[j + 1]) {

                        temp = ary[j];
                        ary[j] = ary[j + 1];
                        ary[j + 1] = temp;
                    }
                }
            }
        }

    }*/
}


