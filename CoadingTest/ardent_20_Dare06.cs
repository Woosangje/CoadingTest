using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ardent_20_Dare01 {
    //도전6 야구게임
    /*
    class MainApp {

        static void Main(string[] args) {
            int[] arrUser = new int[3];
            int[] arrAi = new int[3];
            int strike = 0, ball = 0;
            WriteLine("Start Game!");
            WriteLine("3개의 숫자 선택:");
            Random randomNum = new Random();

            for(int i=0; i<3; i++) {
                
                arrAi[i] = randomNum.Next(0, 10);
                arrUser[i] = int.Parse(ReadLine());
                
                
            }
            WriteLine("도전 결과: 컴퓨터 {0}, {1}, {2} ", arrAi[0], arrAi[1], arrAi[2]);
            for (int i=0; i<3; i++) {

                for(int j=0; j<3-i; i++) {

                    
                    if (arrUser[j] == arrAi[i]) {
                        if (j == i) {
                            strike++;
                        }
                        else {
                            ball++;
                        }
                    }
                    
                    WriteLine("숫자 선택: {0} {1} {2},",arrUser[0], arrUser[1], arrUser[2]);
                    WriteLine("도전 결과 : {0}strike, {1}ball!", strike, ball);
                }
            }
            

        }

    }*/
}


