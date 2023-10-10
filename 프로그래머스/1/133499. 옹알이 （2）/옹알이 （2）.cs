using System;

public class Solution {
    public bool isBabble = false;
    
    public int solution(string[] babbling) {
        int answer = 0;

         foreach(string babble in babbling)
         {
             CheckValidBabble(babble, ref answer);
         }
        return answer;
    }
    
    public void CheckValidBabble(string babble, ref int answer)
    {
        char[] letters = babble.ToCharArray();
             switch(letters[0].ToString())
             {
                 case "a":
                     try
                     {
                         if (letters[1].ToString() != "y") {break;}
                         if (letters[2].ToString() != "a") {break;}
                     }
                     catch(Exception E)
                     {
                         break;
                     }
                     
                     isBabble = true;
                     if(letters.Length > 3)
                     {
                         if (letters[3].ToString() == "a") {break;}
                         string remainingLetters = "";
                         for(int i = 3; i < letters.Length; i ++)
                         {
                             remainingLetters += letters[i];
                         }
                         CheckValidBabble(remainingLetters, ref answer);
                     }
                     else if (isBabble)
                     {
                         answer++;
                     }
                     break;
                 case "y":
                     try
                     {
                         if (letters[1].ToString() != "e") {break;}
                     }
                    catch(Exception E)
                     {
                         break;
                     }
                     isBabble = true;
                     if(letters.Length > 2)
                     {
                         if (letters[2].ToString() == "y") {break;}
                         string remainingLetters = "";
                         for(int i = 2; i < letters.Length; i ++)
                         {
                             remainingLetters += letters[i];
                         }
                         CheckValidBabble(remainingLetters, ref answer);
                     }
                     else if (isBabble)
                     {
                         answer++;
                     }
                     break;
                case "w":
                     try
                     {
                         if (letters[1].ToString() != "o") {break;}
                         if (letters[2].ToString() != "o") {break;}
                     }
                     catch(Exception E)
                     {
                         break;
                     }
                     isBabble = true;
                     if(letters.Length > 3)
                     {
                         if (letters[3].ToString() == "w") {break;}
                         string remainingLetters = "";
                         for(int i = 3; i < letters.Length; i ++)
                         {
                             remainingLetters += letters[i];
                         }
                         CheckValidBabble(remainingLetters, ref answer);
                     }
                     else if (isBabble)
                     {
                         answer++;
                     }
                     break;
                 case "m":
                    try
                     {
                         if (letters[1].ToString() != "a") {break;}
                     }
                    catch(Exception E)
                     {
                         break;
                     }
                     isBabble = true;
                     if(letters.Length > 2)
                     {
                         if (letters[2].ToString() == "m") {break;}
                         string remainingLetters = "";
                         for(int i = 2; i < letters.Length; i ++)
                         {
                             remainingLetters += letters[i];
                         }
                         CheckValidBabble(remainingLetters, ref answer);
                     }
                     else if (isBabble)
                     {
                         answer++;
                     }
                     break;
                 default:
                     break;
                
             }
        isBabble = false;
    }
}