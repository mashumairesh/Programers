using System;

/// <summary>
/// ExampleLink
/// https://school.programmers.co.kr/learn/courses/30/lessons/120921
/// </summary>


internal class Program
{
    static void Main(string[] args)
    {
        Solution tmp = new Solution();

        tmp.solution("hello", "ohell");
    }
}
public class Solution
{
    public int solution(string A, string B)
    {
        int answer = 0;
        char tmp;
        char[] arrTmp;
        arrTmp = new char[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            if (A == B)
                break;
            else
                answer++;

            tmp = A[A.Length - 1];
            for (int j = 0; j < A.Length - 1; j++)
                arrTmp[j + 1] = A[j];
            arrTmp[0] = tmp;
            A = new string(arrTmp);
        }


        if (answer == A.Length)
            answer = -1;


        return answer;
    }
}