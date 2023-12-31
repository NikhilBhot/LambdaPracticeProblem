﻿namespace Lambda_StudentDataManagement
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
                new Student { Id = 1, Name = "John Doe", PhoneNumber = "1234567890", Address = "123 Main St", Age = 20 ,TotalMarks = 80},
                new Student { Id = 2, Name = "Jane Smith", PhoneNumber = "9876543210", Address = "456 Elm St", Age = 19 ,TotalMarks = 60},
                new Student { Id = 3, Name = "Bob Johnson", PhoneNumber = "5555555555", Address = "789 Oak St", Age = 15 ,TotalMarks = 75},
                new Student { Id = 4, Name = "Alice Brown", PhoneNumber = "1111111111", Address = "321 Pine St", Age = 16 ,TotalMarks = 95}
            };

            // Display all student details using lambda expression
            studentList.ForEach(student => Console.WriteLine($"ID: {student.Id}, " +
                $"Name: {student.Name}, Phone: {student.PhoneNumber}, " +
                $"Address: {student.Address}, " +
                $"Age: {student.Age}"));

            // Retrieve all records with age between 12 and 18 using LINQ
            var filteredStudents = studentList.Where(student => student.Age >= 12 && student.Age <= 18);
            Console.WriteLine("______________________________________________________________________________________");
            /*// Retrieve all records with age between 12 and 18 using LINQ
                    var filteredStudents = 
                    studentList.Where(student => student.Age >= 12 && student.Age <= 18);

                    // Display the details of filtered students
                    foreach (var student in filteredStudents)
                    {
                        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Phone: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
                    }
                         */
            // Display the details of filtered students
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"ID: {student.Id}, " +
                    $"Name: {student.Name}, Phone: {student.PhoneNumber}, " +
                    $"Address: {student.Address}, " +
                    $"Age: {student.Age}");
            }
            Console.WriteLine("___________________________________________________________");
            // Sort students in descending order based on TotalMarks
            var sortedStudents = studentList.OrderByDescending(student => student.TotalMarks);

            // Display the details of sorted students
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Total Marks: {student.TotalMarks}");
            }

            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("Display all the student records in each address.");
            // Group students by address
            var groupedStudents = studentList.GroupBy(student => student.Address);

            // Display student records for each address
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Address: {group.Key}");

                foreach (var student in group)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
                }

                Console.WriteLine();
            }
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Fetch first three students records.");
            // Fetch the first three student records
            var firstThreeStudents = studentList.Take(3);

            // Display the details of the first three students
            foreach (var student in firstThreeStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Address: {student.Address}");
            }
            Console.WriteLine("__________________________________________________________________");
            // Search for a particular student based on name
            string searchName = "Bob Johnson";
            var searchedStudent = studentList.FirstOrDefault(student => student.Name == searchName);

            // Display the details of the searched student
            if (searchedStudent != null)
            {
                Console.WriteLine($"ID: {searchedStudent.Id}, Name: {searchedStudent.Name}, Address: {searchedStudent.Address}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}