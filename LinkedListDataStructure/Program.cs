using LinkedListDataStructure.Helper;
using LinkedListDataStructure.Model;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            SparseList[] sparseListAddress = CreateSparseMatrix();
            DisplaySparseMatrix(sparseListAddress);
            Console.ReadKey();
        }

        private static void LinkedListOperation()
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();

            while (true)
            {
                Console.WriteLine
                    ("Please select an option" +
                        Environment.NewLine + "1. Insert a node" +
                        Environment.NewLine + "2. Display List" +
                        Environment.NewLine + "3. Create List" +
                        Environment.NewLine + "4. Get count of node" +
                        Environment.NewLine + "5. Get mid node" +
                        Environment.NewLine + "6. Sorted Insert" +
                        Environment.NewLine + "7. Delete a node" +
                        Environment.NewLine + "8. Check for sorted list" +
                        Environment.NewLine + "9. Remove duplicates" +
                        Environment.NewLine + "10. Reverse the list" +
                        Environment.NewLine + "11. Merge lists" +
                        Environment.NewLine + "12. Check for loop" +
                        Environment.NewLine + "0. Exit"
                    );

                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine(Environment.NewLine + "Input format is not valid. Please try again." + Environment.NewLine);
                    continue;
                }

                if (i == 0)
                {
                    Environment.Exit(0);
                }
                else if (i == 1)
                {
                    Console.WriteLine("Enter the element to insert");
                    int num = Convert.ToInt32(Console.ReadLine());
                    //CircularLinkedList.InsertNode(doublyLinkedList, num);
                }
                else if (i == 2)
                {
                    DoublyLinkedList.DisplayList(doubleLinkedList);
                }
                else if (i == 3)
                {
                    DoublyLinkedList.CreateList(doubleLinkedList);
                }
                else if (i == 4)
                {
                    //Console.WriteLine(CircularLinkedList.RCount(doubleLinkedList.Head, doubleLinkedList.Head));
                }
                else if (i == 5)
                {
                    Console.WriteLine(DoublyLinkedList.MidNode(doubleLinkedList));
                }
                else if (i == 6)
                {
                    Console.WriteLine("Enter the element to insert");
                    int num = Convert.ToInt32(Console.ReadLine());
                    //LinerLinkedList.SortedInsert(doubleLinkedList, num);
                }
                else if (i == 7)
                {
                    Console.WriteLine("Enter the index to delete");
                    int num = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine(CircularLinkedList.DeleteNode(doubleLinkedList, num) > 0 ? "Successfully deleted" : "Not found");
                }
                else if (i == 8)
                {
                    //Console.WriteLine(LinerLinkedList.IsSorted(doubleLinkedList) > 0 ? "Yes" : "No");
                }
                else if (i == 9)
                {
                    //Console.WriteLine(LinerLinkedList.RemoveDuplicates(doubleLinkedList) > 0 ? "Success" : "Failed");
                }
                else if (i == 10)
                {
                    DoublyLinkedList.RReverse(doubleLinkedList, doubleLinkedList.Head);
                }
                else if (i == 11)
                {
                    //LinerLinkedList.Merge(singleLinkedList, singleLinkedList2);
                }
                else if (i == 12)
                {
                    LinerLinkedList.IsLoop();
                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }
            };
        }

        private static SparseList[] CreateSparseMatrix()
        {
            SparseList[] sparseListAddress = new SparseList[5];

            SparseList sparseList;
            SparseNode node;

            sparseList = new SparseList();
            node = new SparseNode { Column = 4, Data = 8, Next = null };
            sparseList.Head = node;
            sparseListAddress[0] = sparseList;

            sparseList = new SparseList();
            node = new SparseNode { Column = 3, Data = 7, Next = null };
            sparseList.Head = node;
            sparseListAddress[1] = sparseList;

            sparseList = new SparseList();
            node = new SparseNode { Column = 0, Data = 5, Next = new SparseNode { Column = 4, Data = 9, Next = null } };
            sparseList.Head = node;
            sparseListAddress[2] = sparseList;

            sparseList = new SparseList();
            node = new SparseNode { Column = 5, Data = 3, Next = null };
            sparseList.Head = node;
            sparseListAddress[3] = sparseList;

            sparseList = new SparseList();
            node = new SparseNode { Column = 0, Data = 6, Next = new SparseNode { Column = 3, Data = 4, Next = null } };
            sparseList.Head = node;
            sparseListAddress[4] = sparseList;

            return sparseListAddress;
        }

        private static void DisplaySparseMatrix(SparseList[] sparseListAddress)
        {
            foreach(var item in sparseListAddress)
            {
                DisplaySparseList(item);
            }
        }

        private static void DisplaySparseList(SparseList sparseList)
        {
            SparseNode node = sparseList.Head;
            
            for (int i = 0; i < 6; i++)
            {
                if (node != null && i == node.Column)
                {
                    Console.Write(node.Data + "\t");
                    node = node.Next;
                }
                else
                {
                    Console.Write(0 + "\t");
                }
            }

            Console.WriteLine();
        }
    }

    class SparseNode
    {
        internal int Column { get; set; }
        internal int Data { get; set; }
        internal SparseNode Next { get; set; }
    }

    class SparseList
    {
        internal SparseNode Head { get; set; }
    }
}
