using LinkedListDataStructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.Helper
{
    internal class CircularLinkedList
    {
        internal static void CreateList(SingleLinkedList singleLinkedList)
        {
            Node tempNode = singleLinkedList.Head;

            for(int i = 0; i < 5; i++)
            {
                Node node = new Node(10 + i);

                if(singleLinkedList.Head == null)
                {
                    singleLinkedList.Head = tempNode = node;
                    continue;
                }

                node.Next = singleLinkedList.Head;
                tempNode.Next = node;
                tempNode = tempNode.Next;
            }
        }

        internal static void DisplayList(SingleLinkedList singleLinkedList)
        {
            Node tempNode = singleLinkedList.Head;

            if (singleLinkedList.Head != null)
            {
                do
                {
                    Console.WriteLine(tempNode.Data);
                    tempNode = tempNode.Next;
                } while (tempNode != singleLinkedList.Head);
            }
        }

        internal static void RDisplayList(Node head, Node node)
        {
            if (head != null)
            {
                if (node.Next == head)
                {
                    Console.WriteLine(node.Data);
                    return;
                }
                Console.WriteLine(node.Data);
                RDisplayList(head, node.Next);
            }
        }

        internal static void InsertNode(SingleLinkedList singleLinkedList, int num)
        {
            Node node = new Node(num);
            
            if(singleLinkedList.Head == null)
            {
                singleLinkedList.Head = node;
                node.Next = node;
            }
            else
            {
                Node tempNode = singleLinkedList.Head;
                while(tempNode.Next != singleLinkedList.Head)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.Next = node;
                node.Next = singleLinkedList.Head;
            }
        }

        internal static int DeleteNode(SingleLinkedList singleLinkedList, int index)
        {
            if(index < 0 || index > Count(singleLinkedList) || singleLinkedList.Head == null)
            {
                return -1;
            }

            Node tempNode = singleLinkedList.Head;

            int data;
            if (index == 1)
            {
                while (tempNode.Next != singleLinkedList.Head)
                {
                    tempNode = tempNode.Next;
                }

                if (tempNode == singleLinkedList.Head)
                {
                    data = tempNode.Data;
                    singleLinkedList.Head = null;
                }
                else
                {
                    data = singleLinkedList.Head.Data;
                    singleLinkedList.Head = singleLinkedList.Head.Next;
                    tempNode.Next = singleLinkedList.Head;
                }
            }
            else
            {
                for (int i = 1; i < index - 1; i++)
                {
                    tempNode = tempNode.Next;
                }

                data = tempNode.Next.Data;
                tempNode.Next = tempNode.Next.Next;
            }

            return data;
        }

        internal static int Count(SingleLinkedList singleLinkedList)
        {
            Node tempNode = singleLinkedList.Head;
            int count = 0;
            if (tempNode != null)
            {
                do
                {
                    count++;
                    tempNode = tempNode.Next;
                } while (tempNode != singleLinkedList.Head);
            }

            return count;
        }

        internal static int RCount(Node head, Node node)
        {
            if(node.Next == head)
            {
                return 1;
            }

            return RCount(head, node.Next) + 1;
        }
    }
}
