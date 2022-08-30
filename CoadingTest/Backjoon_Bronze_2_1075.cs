using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using static System.Console;
namespace Backjoon_Bronze_2_1075 {



    /*
class MainApp {

    static void Main(string[] args) {


        int N = 1000;
        int F = 3;
        int result = GetLast2Dight();

        if(result >= 0 && result < 10) {

            Write("0");
            WriteLine(result);
        }

        int GetLast2Dight() {

            //100의 자리 시작
            int start = (N / 100) * 100;
            int result = 0;

            for(int i= start; i < (start + 100); i++) {

                if(i% F == 0) {
                    result = i % 100;
                    break;
                }
            }
            return result;
        }
    }
}*/
}