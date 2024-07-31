using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> AssignedCourses { get; set; }

        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
            AssignedCourses = new List<string>();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }

        public void AssignCourse(string course)
        {
            AssignedCourses.Add(course);
        }
    }
}
