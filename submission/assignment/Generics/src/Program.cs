using Generics;

var students = new Store<Student>();
students.Add(new Student { Id = 1, Name = "Ahmed" });
students.Add(new Student { Id = 2, Name = "Sara" });
Console.WriteLine(students.GetById(2)?.Name);

var courses = new Store<Course>();
courses.Add(new Course { Id = 10, Title = "OOP", Price = 1500m });
Console.WriteLine(courses.GetById(10)?.Title);