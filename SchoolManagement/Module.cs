using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    public class Module
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Module(string name)
        {
            Name = name;
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Module: {Name}");
            foreach (var course in Courses)
            {
                course.DisplayDetails();
            }
        }
    }
}
