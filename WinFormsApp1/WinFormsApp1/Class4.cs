using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcoursework
{
    class CourseWork
    {
        public string name;
        public string tasks;
        public DateTime date;

        public CourseWork(string name, string tasks, DateTime date)
        {
            this.name = name;
            this.tasks = tasks;
            this.date = date;
        }

        public void printInfo()
        {
            string text = "Tasks: " + this.tasks + "\n" +
                "Name: " + this.name + "\n" + "Date: " + this.date;
            Console.WriteLine(text);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}