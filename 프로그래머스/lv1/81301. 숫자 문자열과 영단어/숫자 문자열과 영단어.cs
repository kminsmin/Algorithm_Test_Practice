using System;

public class Solution {
    public int solution(string s) {
        string answer = "";
        string tempString = "";
        char[] temp = s.ToCharArray();
        for(int i = 0; i < temp.Length; i++)
        {
            if(char.IsDigit(temp[i]))
             {
                 answer += temp[i].ToString();
                 continue;
             }
            else
               {
                   tempString += temp[i].ToString();
                   switch(tempString)
                   {
                       case "zero":
                           answer += "0";
                           tempString = "";
                           break;
                       case "one":
                           answer += "1";
                           tempString = "";
                           break;
                       case "two":
                           answer += "2";
                           tempString = "";
                           break;
                       case "three":
                           answer += "3";
                           tempString = "";
                           break;
                       case "four":
                           answer += "4";
                           tempString = "";
                           break;
                       case "five":
                           answer += "5";
                           tempString = "";
                           break;
                       case "six":
                           answer += "6";
                           tempString = "";
                           break;
                       case "seven":
                           answer += "7";
                           tempString = "";
                           break;
                       case "eight":
                           answer += "8";
                           tempString = "";
                           break;
                       case "nine":
                           answer += "9";
                           tempString = "";
                           break;
                       default:
                           break;
                   }
               }
        }
        return int.Parse(answer);
    }
               
}