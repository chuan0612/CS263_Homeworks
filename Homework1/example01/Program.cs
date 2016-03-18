using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student someone =
                new Student
                {
                    name = "老張",
                    info = new Contact
                    {
                         phone = "0938123456",
                         email = "test@gmail.com"
                    },               
                };
            Console.WriteLine(someone.name);
            Console.WriteLine(someone.info.email);
            Console.WriteLine(someone.info.phone);
        }
    }
}