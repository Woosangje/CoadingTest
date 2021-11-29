using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CoadingTest
{


    public class Solution
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];

            int match_cnt = 0;
            int zero_cnt = 0;

            for(int i=0; i<lottos.length; i++)
            {
                //0인 개수 측정
                if (lottos[i] == 0) zero_cnt++;
                //win_nums 의 길이만큼 도는 inner for
                for(int j=0; j<win_nums.length; j++)
                {
                    //일치하는 번호가 있는 경우 일치개수++
                    if(win_nums[j] == lottos[i])
                    {
                        match_cnt++;
                        break;
                    }
                }
            }

            //최고 순위 세팅
            answer[0] = Math.min(7 - (zero_cnt + match_cnt), 6);
            answer[1] = Math.min(7 - match_cnt, 6);

            return answer;
        }
    }
}
