using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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
         Random randGenerator = new Random();

         try
         {
            //put each line from text file into this array
            string[] lines = System.IO.File.ReadAllLines("AvailableWords.txt");

            int randomIndex = randGenerator.Next(1, lines.Length + 1);

            int count = 0;
            foreach (string line in lines)
            {
               //get the random string from list
               if (count == randomIndex)
               {
                  guessWord = line.ToLower();

               }
               count++;
            }

         }
         catch (IOException e)
         {
            Debug.WriteLine(e.Message);
         }
         Debug.WriteLine(guessWord);
         return guessWord;
      }
      public int[] checkWord()
      {
         //represents if the letter is guess
         //2 = right letter, right position
         //1 = right letter, wrong position
         int[] result = { 0, 0, 0, 0, 0 };

         //the word to guess
         LinkedList toGuessList = breakdownGuessWord(guessWord);

         //this list is to make sure each character can only be guessed once
         bool[] guessedAlready = { false, false, false, false, false };

         //what user guessed
         LinkedList userGuessList = list;

         Node currentSetHead = toGuessList.getHead();
         Node currentUserHead = userGuessList.getHead();

         //guess logic
         int i = 0;
         while (currentSetHead != null)
         {
            //if right letter, right position
            if (currentSetHead.data.Equals(currentUserHead.data))
            {
               result[i] = 2;
               guessedAlready[i] = true;
            }
            else
            {
               //copy the word to guess list so you can start loop from head node
               LinkedList secondarySet = toGuessList;
               Node secondarySetHead = secondarySet.getHead();

               //look through word to guess for current letter the user guessed
               int j = 0;
               while (secondarySetHead != null)
               {
                  //right letter, wrong position
                  if (currentUserHead.data.Equals(secondarySetHead.data) && guessedAlready[j] == false)
                  {
                     result[i] = 1;
                     guessedAlready[j] = true;
                     break;
                  }
                  //iterate
                  secondarySetHead = secondarySetHead.next;
                  j++;
               }
            }

            //iterate
            currentSetHead = currentSetHead.next;
            currentUserHead = currentUserHead.next;
            i++;
         }

         return result;
      }
      //make string into associated linked list
      public LinkedList breakdownGuessWord(String word)
      {
         LinkedList guessWordList = new LinkedList();

         for (int i = 4; i >= 0; i--)
         {
            guessWordList.add(word.Substring(i, 1).ToLower());
         }

         return guessWordList;
      }
      //build linked list from five letters
      public void buildList(String one, String two, String three, String four, String five)
      {
         list = new LinkedList();
         list.add(five.ToLower());
         list.add(four.ToLower());
         list.add(three.ToLower());
         list.add(two.ToLower());
         list.add(one.ToLower());
      }
      //create guessed word from linked list
      public String getUserWord()
      {
         String word = "";
         Node wordHead = list.getHead();

         while (wordHead != null)
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
