using Homework12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> myCollection = new MyCollection<int>();
            myCollection.Add(2);
            myCollection.Add(3);
            myCollection.Add(4);
            myCollection.Add(5);
            myCollection.Add(6);
            MyCollection<int> myCollection2 = new MyCollection<int>();
            myCollection2.Add(20);
            myCollection2.Add(30);

            myCollection.Notify += myCollection2.Add;

            myCollection.Remove(2);
            myCollection.Remove(4);
            myCollection.Remove(5);
        }
    }
}
