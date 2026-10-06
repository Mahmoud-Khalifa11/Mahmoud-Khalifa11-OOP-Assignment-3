namespace Generics;

public static class EnumerableExtensions
{
    // الصفحة 1 هي الأولى
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        if (pageNumber < 1 || pageSize < 1)
            throw new ArgumentOutOfRangeException("Page number and page size must be at least 1.");

        var result = new List<T>();
        var start = (pageNumber - 1) * pageSize;   // index أول عنصر في الصفحة
        var index = 0;

        foreach (var item in source)
        {
            if (index >= start + pageSize) break;  // خلصت الصفحة
            if (index >= start) result.Add(item);
            index++;
        }
        return result;
    }

    public static T? FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
    {
        foreach (var item in source)
            if (item.Id == id) return item;
        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
    {
        var dict = new Dictionary<int, T>();
        foreach (var item in source)
            dict.Add(item.Id, item);
        return dict;
    }
}