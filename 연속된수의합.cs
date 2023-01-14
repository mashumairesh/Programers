using System;

/// <summary>
/// ExampleLink
/// https://school.programmers.co.kr/learn/courses/30/lessons/120923
/// </summary>


internal class Program
{
    static void Main(string[] args)
    {
        Solution tmp = new Solution();
        int[] tmp2 = new int[] { 3, 4, 5 };
        tmp.solution(5, 5);
    }
}


public class Solution
{
    public int[] solution(int num, int total)
    {
        //Case가 1개일 경우 리턴.

        System.Console.WriteLine("CODE RUNNING");

        int[] answer = new int[num];


        if (num == 1)
        { answer[0] = total; return answer; }
        else if (num == 2)
        { answer[0] = (total / 2); answer[1] = (total / 2 + 1); return answer; }

        //Total = 모든 수의 합
        //num = 수의 갯수

        int MiddelValue = total / num;
        bool isCenter = false;
        int MBefore = 0, MFore = 0;

        if (total % num == 0)
        { isCenter = true; MFore = MBefore = num / 2; }
        else
        { MFore = MBefore = num / 2; MBefore--; }

        //배열 로직 변경
        for (int i = 0; i < MBefore; i++)
        {
            answer[i] = MiddelValue - MBefore + i;
        }


        int Holder = 0;
        if (isCenter)
        {
            answer[num / 2] = MiddelValue;
            Holder = 1;
        }
        else
        {
            answer[num / 2 - 1] = MiddelValue;
            Holder = 0;
        }

        for (int i = 0; i < MFore; i++)
        {
            answer[i + MFore + Holder] = MiddelValue + i + 1;
        }

        System.Console.WriteLine(MBefore + " " + MFore + " " + answer.Length + " " + MiddelValue + " " + num / 2);

        for (int i = 0; i < answer.Length; i++)
            System.Console.Write(answer[i].ToString() + " ");


        return answer;
    }
}