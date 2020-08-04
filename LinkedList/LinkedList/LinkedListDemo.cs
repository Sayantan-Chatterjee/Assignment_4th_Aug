using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<String> myList = new LinkedList<String>();

            myList.AddLast("Good");
            myList.AddLast("Evening");
            myList.AddLast("Everyone");
            myList.AddLast("Let's");
            myList.AddLast("Start");

            Console.WriteLine("-------------MyList after doing AddLast-------------");

            foreach (string str in myList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("----------------Count Property---------------");

            if (myList.Count > 0)
                Console.WriteLine("The first node of myList is: {0} ", myList.First.Value);
            else
                Console.WriteLine("myList is empty");

            Console.WriteLine("================================");
            Console.WriteLine("Contains property to find if the element is in the list or not");
            
            if (myList.Contains("Everyone") == true)
            {
                Console.WriteLine("Element Found...!!");
            }

            else
            {
                Console.WriteLine("Element cannot found.");
            }

            Console.WriteLine("===============================");

            string[] myArr = new string[5]; 
            
            myList.CopyTo(myArr, 0);

            Console.WriteLine("Display str after copying:");

            foreach (string str in myArr)
            {
                Console.WriteLine(str);
            }


            Console.WriteLine("--------------To Check The Equals Method------------");

            LinkedList<string> myList1 = new LinkedList<string>();
            myList1 = myList;
            Console.WriteLine(myList1.Equals(myList));
        }
    }
}