using System;
using System.IO;

namespace Codding_Challange
{
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }
        /// <summary>
        /// Insert node in the linkedlist in a given position
        /// </summary>
        /// <param name="head">current head pointer</param>
        /// <param name="data">data to be inserted</param>
        /// <param name="position">position at which data is to be inserted</param>
        /// <returns></returns>
        static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            SinglyLinkedListNode trackHead = head;

            SinglyLinkedListNode insertableNode = new SinglyLinkedListNode(data);

            if(head == null)
            {
                return insertableNode;
            }
            if(position == 0)
            {
                insertableNode.next = head;
                return insertableNode;
            }
            int currentPos = 0;
            while(currentPos < position -1 && head.next != null)
            {
                head = head.next;
                currentPos++;
            }

            SinglyLinkedListNode nodeAtPos = head.next;
            head.next = insertableNode;
            head = head.next;
            head.next = nodeAtPos;

            return trackHead;
        }

        static bool HasCycle(SinglyLinkedListNode head)
        {
            if(head == null){
                return false;
            }

            SinglyLinkedListNode slow = head;
            SinglyLinkedListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;

        }



        /*
         * Main for inserting a node at given position
         * 
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int data = Convert.ToInt32(Console.ReadLine());

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist_head = InsertNodeAtPosition(llist.head, data, position);

            PrintSinglyLinkedList(llist_head, " ", textWriter);
            textWriter.WriteLine();

            textWriter.Flush();
            textWriter.Close();
        }*/

            /// <summary>
            /// Input 1,1,3,1,2,3
            /// </summary>
            /// <param name="args"></param>
        /*
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                int index = Convert.ToInt32(Console.ReadLine());

                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode extra = new SinglyLinkedListNode(-1);
                SinglyLinkedListNode temp = llist.head;

                for (int i = 0; i < llistCount; i++)
                {
                    if (i == index)
                    {
                        extra = temp;
                    }

                    if (i != llistCount - 1)
                    {
                        temp = temp.next;
                    }
                }

                temp.next = extra;

                bool result = hasCycle(llist.head);

                textWriter.WriteLine((result ? 1 : 0));
            }

            textWriter.Flush();
            textWriter.Close();
        }*/
    }
}
