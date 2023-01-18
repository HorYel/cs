using classhuman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classstudent
{

    class Student : Human
    {
        private int group;
        private int course;

        public Student() : base()
        {

        }

        public Student(string name, string surname, int age, string gender, int group, int course) : base()
        {
            this.group = group;
            this.course = course;
        }
        public void printInfo()
        {
            string data =
               base.ToString() + "\n" +
               "Group: " + this.group.ToString() + "\n" +
               "Course: " + this.course.ToString();
            Console.WriteLine(data);

        }


        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        
    }

}