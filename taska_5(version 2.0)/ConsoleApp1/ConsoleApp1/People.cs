using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    abstract class People:IInterface1
    {
        private int age;
        private string name;
        private string location;

    
       public int Age
       {
            get { return age;}
            set
            {
                if (value > 0 && value < 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Incorete date");
                }
            }
       }

       public string Name
       {
           get { return name; }
           set { name = value; }
       }

       public string Location
       {
           get { return location; }
           set { location = value; }
       }


       public abstract void ShowInfo();

       public void PrintAs()
       {
           Console.WriteLine("I am IInterface");
       }
       //void IInterface1.Fun()
       //{
       //    Console.WriteLine("IInterface1");
       //} 

       //void IInterface2.Fun()
       //{
       //    Console.WriteLine("IInterface2");
       //}

    }
}
