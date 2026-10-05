# Part 02 — answers

---

## Reports

- What was the problem?
- What did you change?
- Why did you choose that approach?

---

## Enrollment

- What was the problem?
- What did you change?
- Why did you choose that approach?


# Part 02 — answers

---

## Reports

- What was the problem?
  The three exporters were almost the same code. `Export`, `Load`, `Validate` and `Save` were copied in all of them, and only `Format` was different. Changing a step or its order meant editing three files.
- What did you change?
  Added the abstract class `ReportExporter`. Its `Export` method (the template method) runs Load, Validate, Format, Save in that order, written once. Each exporter now only overrides `Format`. The three report files have the same content as before.
- Why did you choose that approach?
  An abstract class can hold the shared code and fix the order of the steps in one place, and the exporters are really kinds of report exporter. An interface only describes a contract, so each exporter would still have to repeat the shared code.

---

## Enrollment

- What was the problem?
  To enroll one student, `Program.cs` had to create four services, call them in the right order, and pass the invoice id from one call to the next. Every caller would repeat this, and a wrong order would be a bug.
- What did you change?
  Added `EnrollmentFacade` with one method, `Enroll`, that owns the four services and the order. `Services.cs` was not changed, and `Program.cs` makes one call.
- Why did you choose that approach?
  A Facade hides a messy flow behind one simple call. The caller no longer needs to know which services exist, how to create them, the order of the calls, or that the invoice id is needed in the last step.