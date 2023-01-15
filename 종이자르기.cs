using System;

/// <summary>
/// ExampleLink
/// https://school.programmers.co.kr/learn/courses/30/lessons/120922
/// </summary>


internal class Program
{
    static void Main(string[] args)
    {
        Solution tmp = new Solution();

        tmp.solution(2, 2);
    }
}


public class Solution
{
    public int solution(int M, int N)
    {
        int answer = 0;

        int MCuttingCount = 0;
        int NCuttingCount = 0;

        if (M != 1)
        {
            MCuttingCount = M - 1;
        }

        if (N != 0)
        {
            NCuttingCount = M * (N - 1);
        }

        answer = NCuttingCount + MCuttingCount;

        return answer;
    }
}