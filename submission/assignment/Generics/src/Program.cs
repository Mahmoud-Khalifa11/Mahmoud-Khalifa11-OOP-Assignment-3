using Generics;

var store = new StudentStore();
store.Add(new Student { Id = 1, Name = "Ahmed" });
store.Add(new Student { Id = 2, Name = "Sara" });
Console.WriteLine(store.GetById(2)?.Name);

var courses = new CourseStore();
courses.Add(new Course { Id = 10, Title = "OOP", Price = 1500m });
Console.WriteLine(courses.GetById(10)?.Title);
