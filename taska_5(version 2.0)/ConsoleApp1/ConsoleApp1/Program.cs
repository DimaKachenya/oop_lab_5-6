using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    enum myEnum
    {
        first=1,
        second
    }
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            WorkMan workMan = new WorkMan();

            Collection<Student> myStudent = new Collection<Student>();
            Collection<WorkMan> myWorkMan = new Collection<WorkMan>();

            myStudent.Add(student);
            myWorkMan.Add(workMan);

            myWorkMan.ShowInf();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            myStudent.ShowInf();

            myWorkMan.DeleteAll();
            myStudent.DeleteAll();

            myWorkMan.ShowInf();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            myStudent.ShowInf();

            Console.WriteLine(student is Student);
            Console.WriteLine(student is WorkMan);
            Console.WriteLine(student is People);


            object[] o = new object[5];
            o[0] = new Student();
            o[1] = new WorkMan();
            o[2] = "Hello";
            o[3] = 4759.0;
            o[4] = null;
            string str2;

            for (int q = 0; q < o.Length; ++q)
            {
                
                if (o[q] is string)
                {
                    str2 = o[q] as string; //используется только с ссылочным типом данных

                    Console.Write($"{q}:");
                    Console.WriteLine("'" + str2 + "'");
                }
                else
                {
                    Console.WriteLine("Is is not a string");
                }
                
                string str1 = o[q] as string; //используется только с ссылочным типом данных

                Console.Write($"{q}:");

                if (str1 != null)
                {
                    Console.WriteLine("'" + str1 + "'");
                }
                else
                {
                    Console.WriteLine("Is is not a string");
                }
            }

            IInterface1 meInterface=new Student();
            meInterface.PrintAs();

            //IInterface1 myInterface1=myStudent as IInterface1;
            //IInterface2 myInterface2=myWorkMan as IInterface2;
            //myInterface1.Fun();
            //myInterface2.Fun();
            
            int a = 1;
            switch (a)
            {
                case (int)myEnum.first:
                    Console.WriteLine("1");
                    break;
                case (int)myEnum.second:
                    Console.WriteLine("2");
                    break;
            }

            Array allArray = Enum.GetValues((typeof(myEnum)));
            foreach (myEnum some in allArray)
            {
                Console.WriteLine($"some: {some}");
            }


            Type somth=typeof(myEnum);
            foreach (var VARIABLE in Enum.GetNames(somth))
            {
                Console.WriteLine($"some2: {VARIABLE}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
           CollectionOfUser user=new CollectionOfUser();
           user.ReadMyFile();
           user.Show();

           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine();



           List<User> obj = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("Json.json"));
           obj[0].ShowInfo();
           obj[1].ShowInfo();
           obj[2].ShowInfo();

        }
    }
}
