using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ConsoleApp1
{
    class CollectionOfUser
    {
        List<User> myUsers = new List<User>();
           
            string path = @"D:\Lp_Lab_6.txt";
            string inf = String.Empty;
            

        public void ReadMyFile()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    inf += sr.ReadLine() + '\n';
                }

                string promznach=string.Empty;

                //Console.WriteLine(inf);
                User mUser = new User();
                int counter = 0;
                for (int i = 0; i < inf.Length; i++)
                {
                    if (inf[i] != ','&&inf[i]!='\n')
                    {
                        promznach += inf[i];
                    }
                    else
                    {
                        if (counter == 0)
                        {
                            mUser.Id += Convert.ToInt32(promznach);
                            counter++;
                        }
                        else if (counter == 1)
                        {
                            mUser.Username += promznach;
                            counter++;
                        }
                        else if (counter == 2)
                        {
                            mUser.Age += Convert.ToInt32(promznach);
                            counter++;
                        } 

                        if (inf[i] == '\n')
                        {
                            counter = 0;
                            myUsers.Add(mUser);
                            mUser = new User();
                        }
                      
                        promznach = string.Empty;
                        
                    }


                }

                Console.WriteLine(inf);
            }
        }
        public void Show()
        {
            for(int i=0;i<myUsers.Count;i++)
            {
                myUsers[i].ShowInfo();
            }
        }
    }
}
