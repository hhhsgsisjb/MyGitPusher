using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //Create a Class as in The following UML (as Shown in our ClassRoom - Activity 1) in C# , then Print All the field Using a diffrent Class
    internal class Student
    {
        private string name;
        private string address;
        private double mark;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public class StudentInfo
        {
            static void Main(string[] args)
            {
                Student info =new Student();
                info.Name = "Abdullah";
                info.Address = "Baghdad";
                info.Mark = 87.5;
                Console.WriteLine("Name is: "+info.Name);
                Console.WriteLine("Address is: " + info.Address);
                Console.WriteLine("Mark is: "+info.Mark);
                Console.ReadKey();
            }
        }
    }
}
