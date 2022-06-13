using System;
using System.Collections.Generic;
using System.Diagnostics;
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
      public int[] checkWord()
      {
         int[] result = { 0, 0, 0, 0, 0 };

         LinkedList toGuessList = breakdownGuessWord(guessWord);
         //this list is to make sure each character can only be guessed once
         bool[] guessedAlready = { false, false, false, false, false };

         LinkedList userGuessList = list;

         Node currentSetHead = toGuessList.getHead();
         Node currentUserHead = userGuessList.getHead();

         int i = 0;
         while (currentSetHead != null)
         {
            
            if(currentSetHead.data.Equals(currentUserHead.data))
            {
               result[i] = 2;
               guessedAlready[i] = true;
            }
            else
            {
               LinkedList secondarySet = toGuessList;
               Node secondarySetHead = secondarySet.getHead();


               int j = 0;
               while(secondarySetHead != null)
               {
                  if(currentUserHead.data.Equals(secondarySetHead.data) && guessedAlready[j] == false)
                  {
                     result[i] = 1;
                     guessedAlready[j] = true;
                     break;
                  }
                  secondarySetHead = secondarySetHead.next;
                  j++;
               }
            }

            currentSetHead = currentSetHead.next;
            currentUserHead = currentUserHead.next;
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
      public String getUserWord()
      {
         String word = "";
         Node wordHead = list.getHead();

         while(wordHead != null)
         {
            word += wordHead.data;
            wordHead = wordHead.next;
         }

         return word;
      }
      public String getGuessString()
      {
         return guessWord;
      }
   }
}
