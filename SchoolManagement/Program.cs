using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();
        static List<Module> modules = new List<Module>();
        static Admin admin = new Admin("admin", "password");

        static void Main(string[] args)
        {
            Console.Title = "School Management System";

            while (true)
            {
                Console.Clear();
                PrintHeader("School Management System");

                Console.WriteLine("1. Manage Students");
                Console.WriteLine("2. Manage Teachers");
                Console.WriteLine("3. Manage Courses and Modules");
                Console.WriteLine("4. Administration");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ManageStudents();
                        break;
                    case "2":
                        ManageTeachers();
                        break;
                    case "3":
                        ManageCoursesAndModules();
                        break;
                    case "4":
                        Administration();
                        break;
                    case "5":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void PrintHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================");
            Console.WriteLine($"       {title}");
            Console.WriteLine("=====================================");
            Console.ResetColor();
        }

        static void ManageStudents()
        {
            Console.Clear();
            PrintHeader("Manage Students");

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Edit Student");
            Console.WriteLine("4. Delete Student");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ViewStudents();
                    break;
                case "3":
                    EditStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    break;
            }
        }

        static void AddStudent()
        {
            Console.Clear();
            PrintHeader("Add Student");

            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Class: ");
            string studentClass = Console.ReadLine();

            Student student = new Student(id, name, studentClass);
            students.Add(student);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student added successfully.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Current list of students:");
            foreach (var s in students)
            {
                s.DisplayDetails();
            }
            Console.ResetColor();
        }

        static void ViewStudents()
        {
            Console.Clear();
            PrintHeader("View Students");

            if (students.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No students found.");
                Console.ResetColor();
                return;
            }

            foreach (var student in students)
            {
                student.DisplayDetails();
                Console.WriteLine("----------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("End of student list.");
            Console.ResetColor();

            // katsnaa  l user 
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        static void EditStudent()
        {
            Console.Clear();
            PrintHeader("Edit Student");

            Console.Write("Enter Student ID to edit: ");
            int id = int.Parse(Console.ReadLine());

            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                Console.Write("Enter new Student Name (leave blank to keep current): ");
                string name = Console.ReadLine();
                Console.Write("Enter new Student Class (leave blank to keep current): ");
                string studentClass = Console.ReadLine();

                if (!string.IsNullOrEmpty(name))
                {
                    student.Name = name;
                }
                if (!string.IsNullOrEmpty(studentClass))
                {
                    student.Class = studentClass;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student updated successfully.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student not found.");
                Console.ResetColor();
            }
        }

        static void DeleteStudent()
        {
            Console.Clear();
            PrintHeader("Delete Student");

            Console.Write("Enter Student ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student deleted successfully.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student not found.");
                Console.ResetColor();
            }
        }

        static void ManageTeachers()
        {
            Console.Clear();
            PrintHeader("Manage Teachers");

            Console.WriteLine("1. Add Teacher");
            Console.WriteLine("2. View Teachers");
            Console.WriteLine("3. Edit Teacher");
            Console.WriteLine("4. Delete Teacher");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTeacher();
                    break;
                case "2":
                    ViewTeachers();
                    break;
                case "3":
                    EditTeacher();
                    break;
                case "4":
                    DeleteTeacher();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    break;
            }
        }

        static void AddTeacher()
        {
            Console.Clear();
            PrintHeader("Add Teacher");

            Console.Write("Enter Teacher ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Teacher Name: ");
            string name = Console.ReadLine();

            Teacher teacher = new Teacher(id, name);
            teachers.Add(teacher);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Teacher added successfully.");
            Console.ResetColor();
        }

        static void ViewTeachers()
        {
            Console.Clear();
            PrintHeader("View Teachers");

            if (teachers.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No teachers found.");
                Console.ResetColor();
                return;
            }

            foreach (var teacher in teachers)
            {
                teacher.DisplayDetails();
                Console.WriteLine("----------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("End of teacher list.");
            Console.ResetColor();

            
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        static void EditTeacher()
        {
            Console.Clear();
            PrintHeader("Edit Teacher");

            Console.Write("Enter Teacher ID to edit: ");
            int id = int.Parse(Console.ReadLine());

            var teacher = teachers.Find(t => t.Id == id);
            if (teacher != null)
            {
                Console.Write("Enter new Teacher Name (leave blank to keep current): ");
                string name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name))
                {
                    teacher.Name = name;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Teacher updated successfully.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Teacher not found.");
                Console.ResetColor();
            }
        }

        static void DeleteTeacher()
        {
            Console.Clear();
            PrintHeader("Delete Teacher");

            Console.Write("Enter Teacher ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            var teacher = teachers.Find(t => t.Id == id);
            if (teacher != null)
            {
                teachers.Remove(teacher);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Teacher deleted successfully.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Teacher not found.");
                Console.ResetColor();
            }
        }

        static void ManageCoursesAndModules()
        {
            Console.Clear();
            PrintHeader("Manage Courses and Modules");

            Console.WriteLine("1. Add Module");
            Console.WriteLine("2. View Modules");
            Console.WriteLine("3. Add Course to Module");
            Console.WriteLine("4. View Courses in Module");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddModule();
                    break;
                case "2":
                    ViewModules();
                    break;
                case "3":
                    AddCourseToModule();
                    break;
                case "4":
                    ViewCoursesInModule();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    break;
            }
        }

        static void AddModule()
        {
            Console.Clear();
            PrintHeader("Add Module");

            Console.Write("Enter Module Name: ");
            string name = Console.ReadLine();

            Module module = new Module(name);
            modules.Add(module);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Module added successfully.");
            Console.ResetColor();
        }

        static void ViewModules()
        {
            Console.Clear();
            PrintHeader("View Modules");

            foreach (var module in modules)
            {
                module.DisplayDetails();
                Console.WriteLine("----------------------------");
            }
        }

        static void AddCourseToModule()
        {
            Console.Clear();
            PrintHeader("Add Course to Module");

            Console.Write("Enter Module Name: ");
            string moduleName = Console.ReadLine();

            var module = modules.Find(m => m.Name == moduleName);
            if (module != null)
            {
                Console.Write("Enter Course Name: ");
                string courseName = Console.ReadLine();
                Console.Write("Enter Course Content: ");
                string courseContent = Console.ReadLine();

                Course course = new Course(courseName, courseContent);
                module.AddCourse(course);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Course added to module successfully.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Module not found.");
                Console.ResetColor();
            }
        }

        static void ViewCoursesInModule()
        {
            Console.Clear();
            PrintHeader("View Courses in Module");

            Console.Write("Enter Module Name: ");
            string moduleName = Console.ReadLine();

            var module = modules.Find(m => m.Name == moduleName);
            if (module != null)
            {
                module.DisplayDetails();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Module not found.");
                Console.ResetColor();
            }
        }

        static void Administration()
        {
            Console.Clear();
            PrintHeader("Administration");

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (admin.Authenticate(username, password))
            {
                Console.WriteLine("1. Generate Student Performance Report");
                Console.WriteLine("2. Generate Teacher Performance Report");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        GenerateStudentPerformanceReport();
                        break;
                    case "2":
                        GenerateTeacherPerformanceReport();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Authentication failed. Please try again.");
                Console.ResetColor();
            }
        }

        static void GenerateStudentPerformanceReport()
        {
            Console.Clear();
            PrintHeader("Student Performance Report");

            Console.WriteLine("Generating Student Performance Report...");
            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, Class: {student.Class}");
            }
        }

        static void GenerateTeacherPerformanceReport()
        {
            Console.Clear();
            PrintHeader("Teacher Performance Report");

            Console.WriteLine("Generating Teacher Performance Report...");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher ID: {teacher.Id}, Name: {teacher.Name}");
            }
        }
    }
}
