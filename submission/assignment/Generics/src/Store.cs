namespace Generics;

public class Store<T> where T : IHasId
{
    private readonly Dictionary<int, T> _items = new();

    public void Add(T item)
    {
        if (_items.ContainsKey(item.Id))
            throw new InvalidOperationException(
                $"Cannot add {typeof(T).Name}: an item with Id {item.Id} already exists.");
        _items.Add(item.Id, item);
    }

    public T? GetById(int id) =>
        _items.TryGetValue(id, out var item) ? item : default;

    public IReadOnlyCollection<T> GetAll() =>
        new List<T>(_items.Values).AsReadOnly();

    public bool Remove(int id) => _items.Remove(id);
}