﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;

        public Student(String Name, String ID, String Department, float cgpa)
        {
            name = Name;
            id = ID;
            department = Department;
            this.cgpa = cgpa;
        }

        public void showinfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(department);
            Console.WriteLine(cgpa);
        }
    }

    class Triangle

    {
        private int x;
        private int y;
        private int z;

        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void showinfo()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(y);
        }

        public void Testtringle()
        {
            if (x == y)
            {
                if (y == z)
                {
                    Console.WriteLine(" the triangle is equilateral");
                }
                else if (y != z)
                {
                    Console.WriteLine("THE TRIANGLE IS isosceles");
                }

            }
            else
            {
                Console.WriteLine("scalene");
            }

        }

    }

    class ACCOUNT
    {
        private String accName;
        private String acid;
        private int balance;

        public ACCOUNT(String accName, String acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            this.balance = balance + amount;
            Console.WriteLine(balance);
        }

        public void Withdraw(int amount)
        {
            if (balance > amount)
            {
                this.balance = balance - amount;
                Console.WriteLine(balance);
            }

        }
    }

    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;

        public Course(String courseName, String courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine(courseName);
            Console.WriteLine(courseCode);
            Console.WriteLine(courseCredit);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Marium", "18-39059-3", "CSE", 3.73F);
            s1.showinfo();
            Console.WriteLine();
            Triangle t1 = new Triangle(5, 5, 10);
            t1.showinfo();
            t1.Testtringle();
            Console.WriteLine();
            ACCOUNT a1 = new ACCOUNT("Sana", "39059", 10000);
            a1.Deposit(500);
            a1.Withdraw(300);
            Console.WriteLine();
            Course c1 = new Course("PC", "1011", 3);
            c1.ShowCourseInfo();
        }
    }
}