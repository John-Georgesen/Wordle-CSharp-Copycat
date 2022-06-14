using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordleFinal
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public String guessWord;
      public WordFunctions func;

      public int turn = 0;
      public MainWindow()
      {
         InitializeComponent();

         //init necessary class
         func = new WordFunctions();

         //create the word to guess
         guessWord = func.createWord();

         //get user input from keyboard
         this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
      }
      private void OnButtonKeyDown(object sender, KeyEventArgs key)
      {
         //add letters to boxes based on turn
         if (turn == 0)
         {
            //if letter is entered
            if ((key.Key >= Key.A && key.Key <= Key.Z))
            {
               //make sure box is empty
               if (Turn1Letter1.Content == "")
               {
                  Turn1Letter1.Content = key.Key.ToString();
               }
               else if (Turn1Letter2.Content == "")
               {
                  Turn1Letter2.Content = key.Key.ToString();
               }
               else if (Turn1Letter3.Content == "")
               {
                  Turn1Letter3.Content = key.Key.ToString();
               }
               else if (Turn1Letter4.Content == "")
               {
                  Turn1Letter4.Content = key.Key.ToString();
               }
               else if (Turn1Letter5.Content == "")
               {
                  Turn1Letter5.Content = key.Key.ToString();
               }
               else { }
            }
            //if backspace is entered
            if (key.Key == Key.Back)
            {
               //make sure the box is populated
               if (Turn1Letter5.Content != "")
               {
                  Turn1Letter5.Content = "";
               }
               else if (Turn1Letter4.Content != "")
               {
                  Turn1Letter4.Content = "";
               }
               else if (Turn1Letter3.Content != "")
               {
                  Turn1Letter3.Content = "";
               }
               else if (Turn1Letter2.Content != "")
               {
                  Turn1Letter2.Content = "";
               }
               else if (Turn1Letter1.Content != "")
               {
                  Turn1Letter1.Content = "";
               }
            }
         }
         if (turn == 1)
         {
            if ((key.Key >= Key.A && key.Key <= Key.Z))
            {
               if (Turn2Letter1.Content == "")
               {
                  Turn2Letter1.Content = key.Key.ToString();
               }
               else if (Turn2Letter2.Content == "")
               {
                  Turn2Letter2.Content = key.Key.ToString();
               }
               else if (Turn2Letter3.Content == "")
               {
                  Turn2Letter3.Content = key.Key.ToString();
               }
               else if (Turn2Letter4.Content == "")
               {
                  Turn2Letter4.Content = key.Key.ToString();
               }
               else if (Turn2Letter5.Content == "")
               {
                  Turn2Letter5.Content = key.Key.ToString();
               }
               else { }
            }
            if (key.Key == Key.Back)
            {
               if (Turn2Letter5.Content != "")
               {
                  Turn2Letter5.Content = "";
               }
               else if (Turn2Letter4.Content != "")
               {
                  Turn2Letter4.Content = "";
               }
               else if (Turn2Letter3.Content != "")
               {
                  Turn2Letter3.Content = "";
               }
               else if (Turn2Letter2.Content != "")
               {
                  Turn2Letter2.Content = "";
               }
               else if (Turn2Letter1.Content != "")
               {
                  Turn2Letter1.Content = "";
               }
            }
         }
         if (turn == 2)
         {
            if ((key.Key >= Key.A && key.Key <= Key.Z))
            {
               if (Turn3Letter1.Content == "")
               {
                  Turn3Letter1.Content = key.Key.ToString();
               }
               else if (Turn3Letter2.Content == "")
               {
                  Turn3Letter2.Content = key.Key.ToString();
               }
               else if (Turn3Letter3.Content == "")
               {
                  Turn3Letter3.Content = key.Key.ToString();
               }
               else if (Turn3Letter4.Content == "")
               {
                  Turn3Letter4.Content = key.Key.ToString();
               }
               else if (Turn3Letter5.Content == "")
               {
                  Turn3Letter5.Content = key.Key.ToString();
               }
               else { }
            }
            if (key.Key == Key.Back)
            {
               if (Turn3Letter5.Content != "")
               {
                  Turn3Letter5.Content = "";
               }
               else if (Turn3Letter4.Content != "")
               {
                  Turn3Letter4.Content = "";
               }
               else if (Turn3Letter3.Content != "")
               {
                  Turn3Letter3.Content = "";
               }
               else if (Turn3Letter2.Content != "")
               {
                  Turn3Letter2.Content = "";
               }
               else if (Turn3Letter1.Content != "")
               {
                  Turn3Letter1.Content = "";
               }
            }
         }
         if (turn == 3)
         {
            if ((key.Key >= Key.A && key.Key <= Key.Z))
            {
               if (Turn4Letter1.Content == "")
               {
                  Turn4Letter1.Content = key.Key.ToString();
               }
               else if (Turn4Letter2.Content == "")
               {
                  Turn4Letter2.Content = key.Key.ToString();
               }
               else if (Turn4Letter3.Content == "")
               {
                  Turn4Letter3.Content = key.Key.ToString();
               }
               else if (Turn4Letter4.Content == "")
               {
                  Turn4Letter4.Content = key.Key.ToString();
               }
               else if (Turn4Letter5.Content == "")
               {
                  Turn4Letter5.Content = key.Key.ToString();
               }
               else { }
            }
            if (key.Key == Key.Back)
            {
               if (Turn4Letter5.Content != "")
               {
                  Turn4Letter5.Content = "";
               }
               else if (Turn4Letter4.Content != "")
               {
                  Turn4Letter4.Content = "";
               }
               else if (Turn4Letter3.Content != "")
               {
                  Turn4Letter3.Content = "";
               }
               else if (Turn4Letter2.Content != "")
               {
                  Turn4Letter2.Content = "";
               }
               else if (Turn4Letter1.Content != "")
               {
                  Turn4Letter1.Content = "";
               }
            }
         }
         if (turn == 4)
         {
            if ((key.Key >= Key.A && key.Key <= Key.Z))
            {
               if (Turn5Letter1.Content == "")
               {
                  Turn5Letter1.Content = key.Key.ToString();
               }
               else if (Turn5Letter2.Content == "")
               {
                  Turn5Letter2.Content = key.Key.ToString();
               }
               else if (Turn5Letter3.Content == "")
               {
                  Turn5Letter3.Content = key.Key.ToString();
               }
               else if (Turn5Letter4.Content == "")
               {
                  Turn5Letter4.Content = key.Key.ToString();
               }
               else if (Turn5Letter5.Content == "")
               {
                  Turn5Letter5.Content = key.Key.ToString();
               }
               else { }
            }
            if (key.Key == Key.Back)
            {
               if (Turn5Letter5.Content != "")
               {
                  Turn5Letter5.Content = "";
               }
               else if (Turn5Letter4.Content != "")
               {
                  Turn5Letter4.Content = "";
               }
               else if (Turn5Letter3.Content != "")
               {
                  Turn5Letter3.Content = "";
               }
               else if (Turn5Letter2.Content != "")
               {
                  Turn5Letter2.Content = "";
               }
               else if (Turn5Letter1.Content != "")
               {
                  Turn5Letter1.Content = "";
               }
            }
         }
         //when user pressed enter, decide what to do based on turn
         if (key.Key == Key.Enter)
         {
            if (turn == 0)
            {
               int[] checkList = getChecklist(1);

               //right letter, right place
               if (checkList[0] == 2)
               {
                  Turn1Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[1] == 2)
               {
                  Turn1Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[2] == 2)
               {
                  Turn1Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[3] == 2)
               {
                  Turn1Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[4] == 2)
               {
                  Turn1Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }

               //right letter, wrong place
               if (checkList[0] == 1)
               {
                  Turn1Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[1] == 1)
               {
                  Turn1Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[2] == 1)
               {
                  Turn1Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[3] == 1)
               {
                  Turn1Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[4] == 1)
               {
                  Turn1Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }

               //wrong
               if (checkList[0] == 0)
               {
                  Turn1Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[1] == 0)
               {
                  Turn1Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[2] == 0)
               {
                  Turn1Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[3] == 0)
               {
                  Turn1Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[4] == 0)
               {
                  Turn1Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
            }
            if (turn == 1)
            {
               int[] checkList = getChecklist(2);

               //right letter, right place
               if (checkList[0] == 2)
               {
                  Turn2Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[1] == 2)
               {
                  Turn2Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[2] == 2)
               {
                  Turn2Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[3] == 2)
               {
                  Turn2Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[4] == 2)
               {
                  Turn2Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }

               //right letter, wrong place
               if (checkList[0] == 1)
               {
                  Turn2Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[1] == 1)
               {
                  Turn2Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[2] == 1)
               {
                  Turn2Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[3] == 1)
               {
                  Turn2Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[4] == 1)
               {
                  Turn2Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }

               //wrong
               if (checkList[0] == 0)
               {
                  Turn2Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[1] == 0)
               {
                  Turn2Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[2] == 0)
               {
                  Turn2Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[3] == 0)
               {
                  Turn2Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[4] == 0)
               {
                  Turn2Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
            }
            if (turn == 2)
            {
               int[] checkList = getChecklist(3);

               //right letter, right place
               if (checkList[0] == 2)
               {
                  Turn3Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[1] == 2)
               {
                  Turn3Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[2] == 2)
               {
                  Turn3Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[3] == 2)
               {
                  Turn3Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[4] == 2)
               {
                  Turn3Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }

               //right letter, wrong place
               if (checkList[0] == 1)
               {
                  Turn3Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[1] == 1)
               {
                  Turn3Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[2] == 1)
               {
                  Turn3Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[3] == 1)
               {
                  Turn3Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[4] == 1)
               {
                  Turn3Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }

               //wrong
               if (checkList[0] == 0)
               {
                  Turn3Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[1] == 0)
               {
                  Turn3Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[2] == 0)
               {
                  Turn3Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[3] == 0)
               {
                  Turn3Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[4] == 0)
               {
                  Turn3Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
            }
            if (turn == 3)
            {
               int[] checkList = getChecklist(4);

               //right letter, right place
               if (checkList[0] == 2)
               {
                  Turn4Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[1] == 2)
               {
                  Turn4Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[2] == 2)
               {
                  Turn4Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[3] == 2)
               {
                  Turn4Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[4] == 2)
               {
                  Turn4Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }

               //right letter, wrong place
               if (checkList[0] == 1)
               {
                  Turn4Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[1] == 1)
               {
                  Turn4Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[2] == 1)
               {
                  Turn4Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[3] == 1)
               {
                  Turn4Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[4] == 1)
               {
                  Turn4Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }

               //wrong
               if (checkList[0] == 0)
               {
                  Turn4Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[1] == 0)
               {
                  Turn4Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[2] == 0)
               {
                  Turn4Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[3] == 0)
               {
                  Turn4Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[4] == 0)
               {
                  Turn4Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
            }
            if (turn == 4)
            {
               int[] checkList = getChecklist(5);

               //right letter, right place
               if (checkList[0] == 2)
               {
                  Turn5Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[1] == 2)
               {
                  Turn5Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[2] == 2)
               {
                  Turn5Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[3] == 2)
               {
                  Turn5Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }
               if (checkList[4] == 2)
               {
                  Turn5Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
               }

               //right letter, wrong place
               if (checkList[0] == 1)
               {
                  Turn5Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[1] == 1)
               {
                  Turn5Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[2] == 1)
               {
                  Turn5Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[3] == 1)
               {
                  Turn5Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }
               if (checkList[4] == 1)
               {
                  Turn5Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e0e31e"));
               }

               //wrong
               if (checkList[0] == 0)
               {
                  Turn5Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[1] == 0)
               {
                  Turn5Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[2] == 0)
               {
                  Turn5Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[3] == 0)
               {
                  Turn5Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
               if (checkList[4] == 0)
               {
                  Turn5Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#e34230"));
               }
            }
            turn++;

         }
      }
      //see if the guess is correct
      private bool isCorrect()
      {
         String userGuessWord = func.getUserWord();
         String setGuessWord = func.getGuessString();

         if (userGuessWord.Equals(setGuessWord))
         {
            return true;
         }

         return false;
      }
      //get each letter from the boxes based on the turn
      private int[] getChecklist(int turn)
      {
         String letterOne = "";
         String letterTwo = "";
         String letterThree = "";
         String letterFour = "";
         String letterFive = "";

         switch (turn)
         {
            case 1:
               letterOne = Turn1Letter1.Content.ToString();
               letterTwo = Turn1Letter2.Content.ToString();
               letterThree = Turn1Letter3.Content.ToString();
               letterFour = Turn1Letter4.Content.ToString();
               letterFive = Turn1Letter5.Content.ToString();
               break;

            case 2:
               letterOne = Turn2Letter1.Content.ToString();
               letterTwo = Turn2Letter2.Content.ToString();
               letterThree = Turn2Letter3.Content.ToString();
               letterFour = Turn2Letter4.Content.ToString();
               letterFive = Turn2Letter5.Content.ToString();
               break;

            case 3:
               letterOne = Turn3Letter1.Content.ToString();
               letterTwo = Turn3Letter2.Content.ToString();
               letterThree = Turn3Letter3.Content.ToString();
               letterFour = Turn3Letter4.Content.ToString();
               letterFive = Turn3Letter5.Content.ToString();
               break;

            case 4:
               letterOne = Turn4Letter1.Content.ToString();
               letterTwo = Turn4Letter2.Content.ToString();
               letterThree = Turn4Letter3.Content.ToString();
               letterFour = Turn4Letter4.Content.ToString();
               letterFive = Turn4Letter5.Content.ToString();
               break;

            case 5:
               letterOne = Turn5Letter1.Content.ToString();
               letterTwo = Turn5Letter2.Content.ToString();
               letterThree = Turn5Letter3.Content.ToString();
               letterFour = Turn5Letter4.Content.ToString();
               letterFive = Turn5Letter5.Content.ToString();
               break;

         }

         func.buildList(letterOne, letterTwo, letterThree, letterFour, letterFive);
         if (isCorrect())
         {
            //set the letters to green
            switch (turn)
            {
               case 1:
                  Turn1Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn1Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn1Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn1Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn1Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  break;

               case 2:
                  Turn2Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn2Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn2Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn2Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn2Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  break;

               case 3:
                  Turn3Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn3Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn3Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn3Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn3Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  break;

               case 4:
                  Turn4Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn4Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn4Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn4Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn4Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  break;

               case 5:
                  Turn5Letter1.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn5Letter2.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn5Letter3.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn5Letter4.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  Turn5Letter5.Background = new SolidColorBrush((Color)System.Windows.Media.ColorConverter.ConvertFromString("#239e40"));
                  break;

            }
            MessageBox.Show("Congratulations you guessed the correct word!", "Winner!");
            //exit application
            System.Windows.Application.Current.Shutdown();
         }

         return func.checkWord();
      }
   }
}
