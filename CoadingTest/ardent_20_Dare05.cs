using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ardent_20_Dare01 {
    //도전5 가위 바위 보

    /*
    class MainApp {

        static void Main(string[] args) {

            Random randomobj = new Random();
            int win = 0;
            int tie = 0;
            bool lose = false;
            while (true) {

                WriteLine("바위는 1, 가위는 2, 보는 3 입력");
                int user = int.Parse(ReadLine());
                int AI = randomobj.Next(1, 4);

                switch (user) {

                    case 1:
                        if (AI == 1) {
                            WriteLine("당신은 바위 선택, 컴퓨터는 바위 선택, 비겼습니다!");
                            tie++;
                        }
                        if (AI == 2) {
                            WriteLine("당신은 바위 선택, 컴퓨터는 가위 선택, 당신이 이겼습니다!");
                            win++;
                        }
                        if (AI == 3) {
                            WriteLine("당신은 바위 선택, 컴퓨터는 보  선택, 당신이 졌습니다!");
                            WriteLine("{0}승,  {1}무", win, tie);
                            lose = true;
                        }
                        break;

                    case 2:
                        if (AI == 1) {
                            WriteLine("당신은 가위 선택, 컴퓨터는 바위 선택, 당신이 졌습니다!");
                            WriteLine("{0}승,  {1}무", win, tie);
                            lose = true;
                        }
                        if (AI == 2) {
                            WriteLine("당신은 가위 선택, 컴퓨터는 가위 선택, 비겼습니다!");
                            tie++;
                        }
                        if (AI == 3) {
                            WriteLine("당신은 가위 선택, 컴퓨터는 보 선택, 당신이 이겼습니다!");
                            win++;
                        }
                        break;

                    case 3:
                        if (AI == 1) {
                            WriteLine("당신은 보 선택, 컴퓨터는 바위 선택, 당신이 이겼습니다!");
                            win++;
                        }
                        if (AI == 2) {
                            WriteLine("당신은 보 선택, 컴퓨터는 가위 선택, 졌습니다!");
                            WriteLine("{0}승,  {1}무", win, tie);
                            lose = true;
                        }
                        if (AI == 3) {
                            WriteLine("당신은 보 선택, 컴퓨터는 보 선택, 비겼습니다!");
                            tie++;
    
                        }
                        break;
                    default:
                        WriteLine("잘못 입력했습니다");
                        break;
                }
                if (lose == true)
                    break;
             
            }


        }

    }*/
}


