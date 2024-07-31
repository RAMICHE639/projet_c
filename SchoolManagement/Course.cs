namespace SchoolManagement
{
    public class Course
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public Course(string name, string content)
        {
            Name = name;
            Content = content;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Course Name: {Name}, Content: {Content}");
        }
    }
}
