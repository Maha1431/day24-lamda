using System;
using System.Collections.Generic;
using System.Linq;

namespace UserRegistrationUsingLamda
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<UserRegistration> list = new List<UserRegistration>();
            List<UserRegistration> users = new List<UserRegistration>();
            list.Add(new UserRegistration { FirstName = "Raj", LastName = "kumar", Email = "manish11@gmail.com", Password = "agfst76", MobileNumber = "8776665551" });
            list.Add(new UserRegistration { FirstName = "shalu", LastName = "vinai", Email = "shaluvinaai@gmail.com", Password = "hdgsy165", MobileNumber = "8144109898" });
            
            foreach ( UserRegistration user in list)
            {
                Console.WriteLine(user.FirstName + "\n" + user.LastName + "\n" + user.Email + "\n" + user.MobileNumber + "\n" + user.Password + "\n");
            }

            foreach ( UserRegistration item in list.FindAll(u => u.MobileNumber == ("8144109898")).ToList());

            {
                Console.WriteLine("FirstName :" +  "\t\tMobileNumber :" );
                
            }
            Console.ReadKey();
        }
    }
}
