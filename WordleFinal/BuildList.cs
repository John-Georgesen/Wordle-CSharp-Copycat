using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleFinal
{
   public class BuildList
   {
      private LinkedList list;
      public BuildList(String one, String two, String three, String four, String five)
      {
         list = new LinkedList();
         list.add(five);
         list.add(four);
         list.add(three);
         list.add(two);
         list.add(one);
      }
      public string getWord()
      {         
         return list.getWord();
      }
   }
}
