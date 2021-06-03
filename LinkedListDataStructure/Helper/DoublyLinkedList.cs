using LinkedListDataStructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.Helper
{
    internal class DoublyLinkedList
    {
        internal static void CreateList(DoubleLinkedList doubleLinkedList)
        {
            DoublyNode tempNode = doubleLinkedList.Head;

            for (int i = 0; i < 5; i++)
            {
                DoublyNode node = new DoublyNode(10 + i);
                
                if (doubleLinkedList.Head == null)
                {
                    doubleLinkedList.Head = tempNode = node;
                    continue;
                }

                tempNode.Next = node;
                node.Prev = tempNode;
                tempNode = tempNode.Next;
            }
        }

        internal static void DisplayList(DoubleLinkedList doubleLinkedList)
        {
            DoublyNode tempNode = doubleLinkedList.Head;

            while(tempNode != null)
            {
                Console.WriteLine(tempNode.Data);
                tempNode = tempNode.Next;
            }
        }

        internal static void RReverse(DoubleLinkedList doubleLinkedList, DoublyNode node)
        {
            if(node == null)
            {
                return;
            }

            DoublyNode tempNode = node.Prev;
            node.Prev = node.Next;
            node.Next = tempNode;
            doubleLinkedList.Head = node;
            RReverse(doubleLinkedList, node.Prev);   
        }

        internal static int MidNode(DoubleLinkedList doubleLinkedList)
        {
            DoublyNode tempNode = doubleLinkedList.Head;
            DoublyNode nextNode = doubleLinkedList.Head;

            while(nextNode != null)
            {
                nextNode = nextNode.Next;
                if(nextNode != null)
                    nextNode = nextNode.Next;
                if (nextNode != null)
                    tempNode = tempNode.Next;
            }

            return tempNode.Data;
        }
    }
}
