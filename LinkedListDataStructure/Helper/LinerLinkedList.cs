using LinkedListDataStructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.Helper
{
    internal class LinerLinkedList
    {
        internal static void CreateLinkedList(SingleLinkedList singleLinkedList)
        {
            Node tempNode = singleLinkedList.Head;
            Node lastNode = null;

            for (int i = 0; i < 5; i++)
            {
                Node node = new Node(10 + i);

                if (tempNode == null)
                {
                    singleLinkedList.Head = node;
                    lastNode = tempNode = singleLinkedList.Head;
                }
                else if (lastNode == null)
                {
                    while (tempNode.Next != null)
                    {
                        lastNode = tempNode = tempNode.Next;
                    }
                }

                tempNode.Next = node;
                tempNode = node;
            }
        }

        internal static void DisplayLinkedList(SingleLinkedList singleLinkedList)
        {
            Node tempNode = singleLinkedList.Head;

            if (tempNode != null)
            {
                while (tempNode != null)
                {
                    Console.WriteLine(tempNode.Data);
                    tempNode = tempNode.Next;
                }
            }
        }

        internal static void RecursiveDisplayLinkedList(Node node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.Data);
            RecursiveDisplayLinkedList(node.Next);
        }

        internal static int Count(Node node)
        {
            int count = 0;
            if (node != null)
            {
                while (node != null)
                {
                    count++;
                    node = node.Next;
                }
            }

            return count;
        }

        internal static int Sum(Node node)
        {
            int sum = 0;
            if (node != null)
            {
                while (node != null)
                {
                    sum += node.Data;
                    node = node.Next;
                }
            }

            return sum;
        }

        internal static int RecursiveCount(Node node)
        {
            if (node == null)
                return 0;
            return RecursiveCount(node.Next) + 1;
        }

        internal static int RecursiveSum(Node node)
        {
            if (node == null)
                return 0;
            return RecursiveSum(node.Next) + node.Data;
        }

        internal static int Max(Node node)
        {
            int max = int.MinValue;

            if (node != null)
            {
                while (node != null)
                {
                    if (node.Data > max)
                    {
                        max = node.Data;
                    }
                    node = node.Next;
                }
            }

            return max;
        }

        internal static int RMax(Node node)
        {
            if (node == null)
            {
                return int.MinValue;
            }
            int x = RMax(node.Next);
            if (node.Data > x)
                return node.Data;
            else
                return x;
        }

        internal static Node RSearch(Node node, int num)
        {
            if (node == null)
                return null;
            else if (node.Data == num)
                return node;
            return RSearch(node.Next, num);
        }

        internal static void InsertNode(SingleLinkedList singleLinkedList, int num)
        {

            Node newNode = new Node(num);

            if (singleLinkedList.Head == null)
            {
                singleLinkedList.Head = newNode;
            }
            else
            {
                Node tempNode = singleLinkedList.Head;

                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.Next = newNode;
            }
        }

        internal static void SortedInsert(SingleLinkedList singleLinkedList, int num)
        {
            Node node = new Node(num);
            if (singleLinkedList.Head == null)
            {
                singleLinkedList.Head = node;
            }
            else
            {
                Node nextNode = singleLinkedList.Head;
                Node prevNode = singleLinkedList.Head;
                while (nextNode != null && nextNode.Data < num)
                {
                    prevNode = nextNode;
                    nextNode = nextNode.Next;
                }
                if (nextNode == singleLinkedList.Head)
                {
                    node.Next = singleLinkedList.Head;
                    singleLinkedList.Head = node;
                }
                else
                {
                    prevNode.Next = node;
                    node.Next = nextNode;
                }
            }
        }

        internal static int DeleteNode(SingleLinkedList singleLinkedList, int num)
        {
            if (singleLinkedList.Head == null)
            {
                return -1;
            }
            else
            {
                Node prevNode = null;
                Node tempNode = singleLinkedList.Head;

                while (tempNode != null && tempNode.Data != num)
                {
                    prevNode = tempNode;
                    tempNode = tempNode.Next;
                }

                if (tempNode == singleLinkedList.Head)
                {
                    singleLinkedList.Head = singleLinkedList.Head.Next;
                }
                else if (tempNode == null)
                {
                    return -1;
                }
                else
                {
                    prevNode.Next = tempNode.Next;
                }

                return 1;
            }
        }

        internal static int IsSorted(SingleLinkedList singleLinkedList)
        {
            int x = int.MinValue;
            Node tempNode = singleLinkedList.Head;

            while (tempNode != null)
            {
                if (tempNode.Data < x)
                    return -1;
                x = tempNode.Data;
            }

            return 1;
        }

        internal static int RemoveDuplicates(SingleLinkedList singleLinkedList)
        {
            Node tempNode = singleLinkedList.Head;
            Node nextNode = tempNode.Next;

            while (nextNode != null)
            {
                if (tempNode.Data == tempNode.Next.Data)
                {
                    nextNode = nextNode.Next;
                    tempNode.Next = nextNode;
                }
                else
                {
                    tempNode = nextNode;
                    nextNode = nextNode.Next;
                }
            }

            return 1;
        }

        internal static void Reverse(SingleLinkedList singleLinkedList)
        {
            Node tempNode = null;
            Node nextNode = singleLinkedList.Head; ;

            while (nextNode != null)
            {
                Node prevNode = tempNode;
                tempNode = nextNode;
                nextNode = nextNode.Next;

                tempNode.Next = prevNode;
            }

            singleLinkedList.Head = tempNode;
        }

        internal static void RReverse(SingleLinkedList singleLinkedList, Node node, Node nextNode)
        {
            if (nextNode != null)
            {
                RReverse(singleLinkedList, nextNode, nextNode.Next);
                nextNode.Next = node;
            }
            else
            {
                singleLinkedList.Head = node;
            }
        }

        internal static void Merge(SingleLinkedList list1, SingleLinkedList list2)
        {
            if (list1.Head != null && list2.Head != null)
            {
                Node thirdList;
                Node lastNode;
                if (list1.Head.Data >= list2.Head.Data)
                {
                    thirdList = list2.Head;
                    lastNode = thirdList;
                    list2.Head = list2.Head.Next;
                    lastNode.Next = null;
                }
                else
                {
                    thirdList = list1.Head;
                    lastNode = thirdList;
                    list1.Head = list1.Head.Next;
                    lastNode.Next = null;
                }

                while (list1.Head != null && list2.Head != null)
                {
                    if (list1.Head.Data >= list2.Head.Data)
                    {
                        lastNode.Next = list2.Head;
                        list2.Head = list2.Head.Next;
                        lastNode = lastNode.Next;
                        lastNode.Next = null;
                    }
                    else
                    {
                        lastNode.Next = list1.Head;
                        list1.Head = list1.Head.Next;
                        lastNode = lastNode.Next;
                        lastNode.Next = null;
                    }
                }

                if (list1.Head != null)
                {
                    lastNode.Next = list1.Head;
                }
                else if (list2.Head != null)
                {
                    lastNode.Next = list2.Head;
                }
            }
        }

        internal static void IsLoop()
        {
            SingleLinkedList list = new SingleLinkedList();
            Node tempNode = list.Head;
            Node lastNode = null;

            for (int i = 0; i < 5; i++)
            {
                Node node = new Node(10 + i);

                if (tempNode == null)
                {
                    list.Head = node;
                    lastNode = tempNode = list.Head;
                }
                else if (lastNode == null)
                {
                    while (tempNode.Next != null)
                    {
                        lastNode = tempNode = tempNode.Next;
                    }
                }

                tempNode.Next = node;
                tempNode = node;
                tempNode.Next = list.Head;
            }

            Node tempNode1 = list.Head;
            Node tempNode2 = list.Head;

            while (tempNode1 != null && tempNode2 != null && tempNode2.Next != null)
            {
                tempNode2 = tempNode2.Next.Next;
                tempNode1 = tempNode1.Next;

                if (tempNode2 == tempNode1)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No");
            return;
        }
    }
}
