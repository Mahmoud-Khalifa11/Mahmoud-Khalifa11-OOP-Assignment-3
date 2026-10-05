# Collections — Answers

## Task 2.1: Research

Sources: Microsoft Learn (IReadOnlyDictionary), Microsoft Learn (SortedDictionary), plus one more source.

- **IReadOnlyDictionary<TKey,TValue>:** a read-only view of a dictionary. You can look up keys and loop over it, but there is no Add, Remove, or setter. A public method returns it so callers can read the data but cannot change it. (A plain `Dictionary` can be cast back, so wrap it with `ReadOnlyDictionary` for real protection.)
- **SortedDictionary<TKey,TValue>:** a dictionary that keeps its entries sorted by key at all times. It is a balanced tree, so lookup, add and remove are O(log n), while `Dictionary` is O(1) on average but has no order.
- **When to choose SortedDictionary:** when the data must always be in key order while items keep being added, and slightly slower lookup is fine.

## Task 2.2: Pick the collection

| # | Collection | Why |
|---|-----------|-----|
| S1 | Dictionary | Lookup by key is O(1). |
| S2 | HashSet | A set never stores a duplicate. |
| S3 | List | Keeps entry order and allows duplicates. |
| S4 | IReadOnlyDictionary | Callers can read prices but cannot change them. |
| S5 | SortedDictionary | Stays sorted by key when sessions are added. |
| S6 | IEnumerable | Lazy: stopping early skips the rest. |