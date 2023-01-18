using classhuman;
using classstudent;
using classteacher;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Net;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Mariia", "Shcherban", 49, "female", 10000, "KSU", 30);
            Human human1 = new Human();
            Student student1 = new Student("Volodymyr", "Makedon", 18, "male", 241, 2);
            Student student2 = new Student("Yelyzaveta", "Horych", 19, "female", 241, 2);
            teacher.add(student1);
            teacher.add(student2);
            teacher.show();
        }
    }
}