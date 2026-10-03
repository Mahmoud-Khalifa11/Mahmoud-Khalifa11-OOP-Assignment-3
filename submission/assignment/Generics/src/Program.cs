using Generics;

// 5 طلاب و3 كورسات
var students = new Store<Student>();
students.Add(new Student { Id = 1, Name = "Ahmed" });
students.Add(new Student { Id = 2, Name = "Sara" });
students.Add(new Student { Id = 3, Name = "Omar" });
students.Add(new Student { Id = 4, Name = "Mona" });
students.Add(new Student { Id = 5, Name = "Youssef" });

var courses = new Store<Course>();
courses.Add(new Course { Id = 10, Title = "OOP", Price = 1500m });
courses.Add(new Course { Id = 11, Title = "SQL", Price = 1200m });
courses.Add(new Course { Id = 12, Title = "ASP.NET", Price = 2000m });

Console.WriteLine(students.GetById(3)?.Name);
Console.WriteLine(courses.GetById(11)?.Title);

try
{
    students.Add(new Student { Id = 3, Name = "Duplicate" });
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

foreach (var s in students.GetAll().Page(2, 2))
    Console.WriteLine($"{s.Id}: {s.Name}");

var courseList = new List<Course>(courses.GetAll());
Console.WriteLine(courseList.FindById(12)?.Title);

// must NOT compile: string مش بيطبّق IHasId
var bad = new Store<string>();