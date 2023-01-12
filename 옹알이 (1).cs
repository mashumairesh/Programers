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
        //string[] tmptmp = { "aya", "yee", "u", "maa", "wyeoo" };
        string[] tmptmp = { "ayaye", "uuuma", "ye", "yemawoo", "ayaa", "maayaye", "maaya", "ayama" };
        //string[] tmptmp = { "ayaye"};
        tmp.solution(tmptmp);
    }
}


public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        //1. 가진 문자열이 존재.
        string[] DefaultBab = { "woo", "ma", "ye", "aya" };
        string strings;
        int[] indexCount = { 0, 0, 0, 0 };
        int Amount = 0;

        //4개의 문자열을 사용하여 반복해서 자르기를 시도.
        //4개의 문자열을 이용하여 자를 수 있다면 패스
        //4개의 문자열을 이용했는데도 자를 수 없다면 False.
        //반복...

        //옹알이 받아온 만큼 실행.
        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < indexCount.Length; j++)
                indexCount[j] = 0;
            Amount = 0;
            strings = babbling[i];

            for (int j = 0; j < DefaultBab.Length; j++)
                strings = strings.Replace(DefaultBab[j], "1");

            for (int j = 0; j < strings.Length; j++)
            {
                if (strings[j] != '1')
                    break;
                else
                    Amount++;
            }
            if (strings.Length == Amount)
                answer++;
        }

        System.Console.WriteLine(answer);
        return answer;
    }
}