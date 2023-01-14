using System;
using System.Collections.Specialized;
using System.Diagnostics;

/// <summary>
/// ExampleLink
/// https://school.programmers.co.kr/learn/courses/30/lessons/120956
/// </summary>


internal class Program
{
    static void Main(string[] args)
    {
        Solution tmp = new Solution();
        int[] tmp2 = new int[] { 1, 2, 3, 4 };
        tmp.solution(tmp2);
    }
}


public class Solution
{
    public int solution(int[] common)
    {
        int answer = 0;

        //등차수열
        //등비수열

        bool isAP = false;
        int Gab = 0, GabBefore = 0;

        //등차수열과 등비수열 을 구분해야함.
        for (int i = 0; i < common.Length - 1; i++)
        {
            Gab = common[i + 1] - common[i];

            //등차
            if (Gab == GabBefore)
                isAP = true;
            else
                isAP = false;

            GabBefore = Gab;
        }

        if (isAP)
            answer = common[common.Length - 1] + Gab;
        else
        {
            answer = common[common.Length - 1] * (common[2] / common[1]);
        }
        return answer;
    }
}