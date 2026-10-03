namespace Generics;

public class StudentStore
{
    private readonly List<Student> _students = new();

    public void Add(Student student) => _students.Add(student);

    public Student? GetById(int id)
    {
        foreach (var s in _students)
            if (s.Id == id) return s;
        return null;                 // مش لاقيه
    }

    public List<Student> GetAll() => _students;

    public bool Remove(int id)
    {
        var student = GetById(id);
        return student is not null && _students.Remove(student);
    }
}
