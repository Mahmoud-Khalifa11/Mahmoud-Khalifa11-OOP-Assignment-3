# Part 03 — answers

---

## BlockedUsers

- Time complexity before:
- Time (ms) before:
- What did you change?
- Time complexity after:
- Time (ms) after:

---

## Students

- What was the problem?
- What did you change?




# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n * m). `List.Contains` scans the list (n = 50,000 blocked ids) for every one of the m = 5,000 requests.
- Time (ms) before: 12 ms (same result in 3 runs, found = 5000)
- What did you change?
  Built a `HashSet<int>` from `blockedIds` once and used its `Contains`. A hash set finds an item without scanning, so each lookup is O(1) on average. The result is the same, found = 5000.
- Time complexity after: O(n + m). O(n) to build the set once, then O(1) for each of the m lookups.
- Time (ms) after: 0–1 ms (3 runs: 1, 0, 1 ms, found = 5000)

---

## Students

- What was the problem?
  `GetAllStudents()` built a list of 1,000,000 students and returned it before the caller read any of them. `Program.cs` prints only 3 and stops, so about 999,997 objects were created for nothing.
- What did you change?
  Changed the return type to `IEnumerable<Student>` and used `yield return`. Now each student is created only when the `foreach` asks for the next one, so stopping after 3 creates only 3 students. The program still prints the first 3.

