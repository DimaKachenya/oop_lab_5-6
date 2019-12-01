using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    sealed class Student:People
    {
        private string university;
        private int money;

        public string University
        {
            get => university;
            set => university = value;
        }

        public int Money
        {
            get => money;
            set => money = value;
        }

        public Student()
        {
            Name = "Dima";
            University = "BELSTU";
            Money = 0;
            Location = "Mazyr";
            Age = 19;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"name: {Name}\n" +
                              $"age: {Age}\n" +
                              $"location: {Location}\n" +
                              $"university: {University}\n" +
                              $"money: {Money}");
        }

    }
}
