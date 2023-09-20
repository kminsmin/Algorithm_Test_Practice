public class Solution {
    enum DayType {
            SUN,
            MON,
            TUE,
            WED,
            THU,
            FRI,
            SAT
        }
    public string solution(int a, int b) {
        string answer = "";
        b--;
        while(b>=0)
        {
            b -= 7;
        }
        
        switch(a)
        {
            case 1:
                b =((5+b)>=0)? 5+b : 12 + b;
                break;
            case 2:
                b =((1+b)>=0)? 1+b : 8 + b;
                break;
            case 3:
                b =((2+b)>=0)? 2+b : 9 + b;
                break;
            case 4:
                b =((5+b)>=0)? 5+b : 12 + b;
                break;
            case 5:
                b =(b>=0)? b : 7 + b;
                break;
            case 6:
                b =((3+b)>=0)? 3+b : 10 + b;
                break;
            case 7:
                b =((5+b)>=0)? 5+b : 12 + b;
                break;
            case 8:
                b =((1+b)>=0)? 1+b : 8 + b;
                break;
            case 9:
                b =((4+b)>=0)? 4+b : 11 + b;
                break;
            case 10:
                b =((6+b)>=0)? 6+b : 13 + b;
                break;
            case 11:
                b =((2+b)>=0)? 2+b : 9 + b;
                break;
            case 12:
                b =((4+b)>=0)? 4+b : 11 + b;
                break;
        }
        answer += ((DayType)b).ToString();
        return answer;
    }
}