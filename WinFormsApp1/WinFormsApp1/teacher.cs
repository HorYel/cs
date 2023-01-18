using classhuman;
using classstudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classteacher
{
    
    class Teacher
    {
        private int salary;
        private string department;
        private int numofseats;
        private List<Student> list;

        public Teacher()
        {
            list = new List<Student>();
        }
        public Teacher(string name, string surname, int age, string gender, int salary, string department, int numofseats)
        {
            this.salary = salary;
            this.department = department;
            this.list = new List<Student>();
        }

        public void add(Student human)
        {
            list.Add(human);
        }


        public void show()
        {
            for (int n = 0; n < list.Count(); n++)
                list[n].printInfo();
        }

        public void printInfo()
        {
            string data =
               base.ToString() + "\n" +
               "Salary: " + this.salary.ToString() + "\n" +
               "Money: " + this.department;
            Console.WriteLine(data);

        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public List<Student> List
        {
            get { return list; }
            set { list = value; }
        }


    }
}
