# Generics — Answers

## Step 2: Same vs different
**Same:** the four methods, the internal `List`, and the logic inside them.
**Different:** only the type (`Student` vs `Course`). It is copy-paste with one type swapped.

## Step 3: Compiler error
```
error CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)
```
`Store<T>` must work for any type, so the compiler only knows `T` is an `object`, and `object` has no `Id`. It rejects the code at compile time instead of crashing at runtime.

## Step 7: Why `new Store<string>()` must NOT compile
```
error CS0311: The type 'string' cannot be used as type parameter 'T' in the generic type or method 'Store<T>'. There is no implicit reference conversion from 'string' to 'Generics.IHasId'.
```
`Store<T>` requires `where T : IHasId`, and `string` has no `Id`, so it breaks the constraint.

## Last question
**Generic Repository**.