# Uninitialized Property Access in C# 
This repository demonstrates a common error in C#: accessing a property before it has been initialized. This can lead to unpredictable behavior, such as exceptions or unexpected values.

## The Bug
The `bug.cs` file contains a class `MyClass` with a property `MyProperty` and a method `MyMethod`. The `MyMethod` accesses `MyProperty` before it is assigned a value.

## The Solution
The `bugSolution.cs` file provides a corrected version where `MyProperty` is initialized before use.

## How to reproduce the bug
1. Compile and run the `bug.cs` file.
2. Observe the output; it may vary depending on the runtime environment.

## How to solve the bug
1. Use the corrected code in `bugSolution.cs` as a reference.
2. Initialize `MyProperty` before accessing it within `MyMethod`.