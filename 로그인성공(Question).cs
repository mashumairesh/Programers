using System;

/// <summary>
/// ExampleLink
/// https://school.programmers.co.kr/learn/courses/30/lessons/120883
/// </summary>


internal class Program
{
    static void Main(string[] args)
    {
        Solution tmp = new Solution();

        string[] lsh = { "programmer01", "15789" };
        string[,] rsh = { { "programmer02", "111111" }, { "programmer00", "134" }, { "programmer01", "1145" } };

        tmp.solution(lsh, rsh);
    }
}
public class Solution
{
    public string solution(string[] id_pw, string[,] db)
    {
        string answer = "";
        bool HasId = false;
        bool HasPw = false;
        int ColectIndex = 0;
        for (int i = 0; i < db.Length / 2; i++)
        {
            //아이디 동일 여부 파악
            if (id_pw[0] == db[i, 0])
            { HasId = true; ColectIndex = i; break; }
        }

        //해당 인덱스의 비밀번호 검사
        if (HasId)
        {
            if (id_pw[1] == db[ColectIndex, 1])
                HasPw = true;
        }

        if (HasId && HasPw)
            answer = "login";
        else if (HasId && !HasPw)
            answer = "wrong pw";
        else if (!HasId && !HasPw || !HasId)
            answer = "fail";


        return answer;
    }
}