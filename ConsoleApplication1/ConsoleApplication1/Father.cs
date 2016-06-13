using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
  public class Father<T> 
    {

         private Node head;
// The nested type is also generic on T.
        private class Node          
        {
            private Node next;
//T as private member data type:
            private T data;         
//T used in non-generic constructor:
            public Node(T t)        
            {
                next = null;
                data = t;
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
//T as return type of property:
            public T Data           
            {
                get { return data; }
                set { data = value; }
            }
        }
        public Father()
        {
            head = null;
        }
//T as method parameter type:
        public void AddHead(T t)    
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }
 
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
 
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
