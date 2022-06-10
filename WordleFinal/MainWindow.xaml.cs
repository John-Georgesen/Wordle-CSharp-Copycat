using System;
using System.Collections.Generic;
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
      public MainWindow()
      {
         InitializeComponent();

         func = new WordFunctions();
         guessWord = func.createWord();

         this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
      }
      private void OnButtonKeyDown(object sender, KeyEventArgs key)
      {
         if ((key.Key >= Key.A && key.Key <= Key.Z))
         {
            if (Letter1.Content == "")
            {
               Letter1.Content = key.Key.ToString();
            }
            else if(Letter2.Content == "")
            {
               Letter2.Content = key.Key.ToString();
            }
            else if (Letter3.Content == "")
            {
               Letter3.Content = key.Key.ToString();
            }
            else if (Letter4.Content == "")
            {
               Letter4.Content = key.Key.ToString();
            }
            else if (Letter5.Content == "")
            {
               Letter5.Content = key.Key.ToString();
            }
            else { }
         }
         if (key.Key == Key.Back)
         {
            if(Letter5.Content != "")
            {
               Letter5.Content = "";
            }
            else if (Letter4.Content != "")
            {
               Letter4.Content = "";
            }
            else if (Letter3.Content != "")
            {
               Letter3.Content = "";
            }
            else if (Letter2.Content != "")
            {
               Letter2.Content = "";
            }
            else if (Letter1.Content != "")
            {
               Letter1.Content = "";
            }
         }
         if (key.Key == Key.Enter)
         {
            String letterOne = Letter1.Content.ToString();
            String letterTwo = Letter2.Content.ToString();
            String letterThree = Letter3.Content.ToString();
            String letterFour = Letter4.Content.ToString();
            String letterFive = Letter5.Content.ToString();

            func.buildList(letterOne, letterTwo, letterThree, letterFour, letterFive);
            bool[] checkList = func.checkWord();

            if (checkList[0] == true)
            {
               Rect1.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            }
            if (checkList[1] == true)
            {
               Rect2.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            }
            if (checkList[2] == true)
            {
               Rect3.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            }
            if (checkList[3] == true)
            {
               Rect4.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            }
            if (checkList[4] == true)
            {
               Rect5.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            }
         }
      }
   }
}
