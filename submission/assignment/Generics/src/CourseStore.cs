namespace Generics;

public class CourseStore
{
    private readonly List<Course> _courses = new();

    public void Add(Course course) => _courses.Add(course);

    public Course? GetById(int id)
    {
        foreach (var c in _courses)
            if (c.Id == id) return c;
        return null;
    }

    public List<Course> GetAll() => _courses;

    public bool Remove(int id)
    {
        var course = GetById(id);
        return course is not null && _courses.Remove(course);
    }
}
