﻿using System;

namespace User_Class_Implementation
{
    class Program
    {
        private static void Main(string[] args)
        {
            while(true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if(userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()}");                
            }
        }
    }
}
