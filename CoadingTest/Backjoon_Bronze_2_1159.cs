using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using static System.Console;
namespace Backjoon_Bronze_2_1152 {

    /*
    class MainApp {

        static void Main(string[] args) {

            char now;
            WriteLine("선수의 수");
            int N = int.Parse(ReadLine());
            bool isExist = false;
            List<char> initial = new List<char>();
            List<int> count = new List<int>();
            List<char> final = new List<char>();
            int sb;
            while(N -- > 0) {

                now = ReadLine()[0];
                for(int i =0; i< initial.Count; i++) {

                    if (now.Equals(initial[i])) {

                        isExist = true;
                        count[i]++;
                        break;
                    }

                }
                if (!isExist) {
                    initial.Add(now);
                    count.Add(1);
                }
                
            }
            for(int i =0; i < initial.Count; i++) {

                if(count[i] > 4) {

                    final.Add(initial[i]);
                }
            }
            while(final.Count != 0) {

                sb.Append(final.Min());
                final.Remove(final.Min());
            }
            if (sb.Length == 0)
                sb.Appendline("PREDAJA");

            Console.WriteLine(sb);

        }

    }*/
    
}