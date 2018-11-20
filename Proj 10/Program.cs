using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Student S1 = new Student(310360330, 80, "Yakov");
            Student S2 = new Student(312231, 60, "ben");
            S1.PrintStudent();
            S2.PrintStudent();
            Console.WriteLine("How Many Students you have?:");

            int num=int.Parse(Console.ReadLine());
            Student[] MyClass = new Student[num];
            {
                for(int i = 0; i < MyClass.Length; i++)
                {

                }
            }


        }
    }
    class Student
    {
        private int Sid;
        private int Sgrade;
        private string Sname;


        public Student(int Sid, int Sgrade, string Sname)
        {
            SetId(Sid);
            SetGrade(Sgrade);
            SetName(Sname);
        }
        public void SetId(int NewId)
        {
            if (0 <= NewId)
            {
                Sid = NewId;
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
        public void SetGrade(int NewGrade)
        {
            if (0 <= NewGrade)
            {
                Sgrade = NewGrade;
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
        public void SetName(string NewName)
        {
            if (NewName.Length > 2)
            {
                Sname = NewName;
            }

        }
        public int GetId()
        {
            return Sid;

        }
        public int GetGrade()
        {
            return Sgrade;

        }
        public string GetName()
        {

            return Sname;
        }
        public void PrintStudent()
        {
            Console.WriteLine($"Student id={Sid}, Student Grade={Sgrade}, Student Name={Sname}");
        }
    }




}
