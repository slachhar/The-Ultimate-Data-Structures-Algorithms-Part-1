using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Class
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class LinkedList
    {
        private Node<int> head;
        private Node<int> tail;

        //addFirst
        public void addFirst(int item)
        {
            if (head.value == 0)
            {
                head.value = item;
                tail = head;
            }
            else
            {
                head.next = new Node<int>() { value = item };
                tail = head.next;
            }
        }

        //addLast
        //deleteFirst
        //deleteLast
        //contains
        //indexOf
    }

    internal class Node<T>
    {
        internal Node<T> next;
        public T value;
    }
}
