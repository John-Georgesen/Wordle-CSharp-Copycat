﻿using System;
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
      public Node getHead()
      {
         return head;
      }
   }
}
