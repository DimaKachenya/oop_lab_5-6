using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    sealed class WorkMan:People
    {
        private string position;
        private string workPlace;
        private int salary;

        public string Position
        {
            get => position;
            set => position = value;
        }

        public string WorkPlace
        {
            get => workPlace;
            set => workPlace = value;
        }

        public int Salary
        {
            get => salary;
            set => salary = value;
        }

        public WorkMan()
        {
            Name = "Dima";
            Age = 19;
            WorkPlace = "Google";
            Position = "Director of everything";
            Salary = 100000000;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"name: {Name}\n" +
                              $"age: {Age}\n" +
                              $"work place: {WorkPlace}\n"+
                              $"position: {Position}\n" +
                              $"salary: {Salary}");
        }
    }
}
