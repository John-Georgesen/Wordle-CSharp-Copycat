using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleFinal
{
   public class WordFunctions
   {
      private LinkedList list;
      private String guessWord;
      public String createWord()
      {
         guessWord = "stall";
         return guessWord;
      }
      public bool[] checkWord()
      {
         bool[] result = { false, false, false, false, false };

         LinkedList setWordList = breakdownGuessWord(guessWord);
         LinkedList userWordList = list;

         Node currentSet = setWordList.getHead();
         Node currentUser = userWordList.getHead();

         int i = 0;
         while (currentSet != null)
         {
            
            if(currentSet.data.Equals(currentUser.data))
            {
               result[i] = true;
            }

            currentSet = currentSet.next;
            currentUser = currentUser.next;
            i++;
         }

         return result;
      }
      public LinkedList breakdownGuessWord(String word)
      {
         LinkedList guessWordList = new LinkedList();

         for(int i = 4; i >= 0; i--)
         {
            guessWordList.add(word.Substring(i,1).ToLower());
         }

         return guessWordList;
      }
      public void buildList(String one, String two, String three, String four, String five)
      {
         list = new LinkedList();
         list.add(five.ToLower());
         list.add(four.ToLower());
         list.add(three.ToLower());
         list.add(two.ToLower());
         list.add(one.ToLower());
      }
      public string getWord()
      {
         return list.getWord();
      }
   }
}
