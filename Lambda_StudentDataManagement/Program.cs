namespace Lambda_StudentDataManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Data Management Using Lambda");
            /*1) Create Student class with Id, Name, Phone Number, Address and Age fields.
                - Create variable for List of Student class in Main method.
                - Add default values in created list.
                - Display all student details.
             */
            List<Student> studentList = new List<Student>()
            {
                new Student { Id = 1, Name = "John Doe", PhoneNumber = "1234567890", Address = "123 Main St", Age = 20 },
                new Student { Id = 2, Name = "Jane Smith", PhoneNumber = "9876543210", Address = "456 Elm St", Age = 19 },
                new Student { Id = 3, Name = "Bob Johnson", PhoneNumber = "5555555555", Address = "789 Oak St", Age = 21 }
            };

            // Display all student details using lambda expression
            studentList.ForEach(student => Console.WriteLine($"ID: {student.Id}, " +
                $"Name: {student.Name}, Phone: {student.PhoneNumber}, " +
                $"Address: {student.Address}, " +
                $"Age: {student.Age}"));
        }
    }
}