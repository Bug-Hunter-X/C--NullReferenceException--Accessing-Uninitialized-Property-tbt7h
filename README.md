# C# NullReferenceException Example

This repository demonstrates a common C# error: the `NullReferenceException`. This exception occurs when you try to access a member (like a property or method) of an object that is currently `null`.  The provided code shows how this error arises when using a property that hasn't been initialized and a solution to prevent the error.

## How to reproduce
1. Clone the repository.
2. Open the `bug.cs` file.
3. Run the code. You'll observe a `NullReferenceException`.

## Solution
The `bugSolution.cs` file demonstrates a way to prevent this error by initializing the property before accessing it.