using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleFinal
{
   public class LinkedList
   {
      private Node head;

      public void add(Object data)
      {
         Node toAdd = new Node();

         toAdd.data = data;
         toAdd.next = head;

         head = toAdd;
      }
      public String getWord()
      {
         String finalString = "";

         Node current = head;

         while (current != null)
         {
            finalString += current.data;
            current = current.next;
         }

         return finalString;
      }
      public Node getHead()
      {
         return head;
      }
   }
}
