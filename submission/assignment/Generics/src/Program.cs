using Generics;

var store = new StudentStore();
store.Add(new Student { Id = 1, Name = "Ahmed" });
store.Add(new Student { Id = 2, Name = "Sara" });
Console.WriteLine(store.GetById(2)?.Name);
