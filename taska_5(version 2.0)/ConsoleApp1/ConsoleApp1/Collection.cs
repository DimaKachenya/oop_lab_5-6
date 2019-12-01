using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Collection<T> where T:People
    {
        List<T> myPeople = new List<T>();
        //public List<T> this[int i]
        //{
        //    get { return myPeople;}
        //    set { myPeople[i] = value; }

        //}
       
        public void Add(T people)
        {
           myPeople.Add(people);
        }

       public void DeleteLast()
       {
           if (myPeople.Count != 0)
           {
               myPeople.RemoveAt(myPeople.Count - 1);
           }
           else
           {
               Console.WriteLine("Collection is void.");
           }
       }

       public void DeleteAll()
       {
           myPeople.Clear();
       }

       public void ShowInf()
       {
           for (int i = 0; i < myPeople.Count; i++)
           {
               myPeople[i].ShowInfo();
           }
       }

       public void FindInf(int i)
       {
           if (i >= 0 && i <= myPeople.Count)
           {
               myPeople[i - 1].ShowInfo();
           }
       }

       public void ShowNumber()
       {
           Console.WriteLine(myPeople.Count);
       }
    }
}
