using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public List<string> Courses { get; set; }

        public Student(int id, string name, string studentClass)
        {
            Id = id;
            Name = name;
            Class = studentClass;
            Courses = new List<string>();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Class: {Class}");
        }

        public void AddCourse(string course)
        {
            Courses.Add(course);
        }
    }
}
