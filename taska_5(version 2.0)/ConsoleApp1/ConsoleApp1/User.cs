using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine( $"Id:{Id}, User Name: {Username}, Age:{Age}");
        }


    }
}
