using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample70
{
    class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 3)
                    Console.WriteLine("이름은 3자 이상 넘을 수 없습니다.");
                else
                    name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Age = 13;
            student.Name = "로버트 할리";
            student.Name = "김철수";

            Console.WriteLine("저의 이름은 " + student.Name + "이고, 나이는 " + student.Age + "살 입니다.");
        }
    }
}

     