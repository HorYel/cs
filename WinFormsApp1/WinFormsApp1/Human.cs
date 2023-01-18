using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classhuman
{
    class Human
    {
        public string name;
        public string surname;
        public int age;
        public string gender;


        public void setName(String name)
        {
            this.name = name;
        }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setGender(String gender)
        {
            this.gender = gender;
        }
        public void inputInfo(string b)
        {
            this.name = "Yelyzaveta";
            this.surname = "Horych";
            this.age = 18;
            this.gender = "female";
        }

        public void printInfo(string a)
        {
            string data =
                "Name: " + this.name + "\n" +
                "Surname: " + this.surname + "\n" +
                "Age: " + this.age.ToString() + "\n" +
                "Gender: " + this.gender;

            Console.WriteLine(data);
        }

        public string getInfo()
        {
            return
                "Name: " + this.name + "\n" +
                "Surname: " + this.surname + "\n" +
                "Age: " + this.age.ToString() + "\n" +
                "Gender: " + this.gender;
        }

        public void inputInfo()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
        }



    }


}
