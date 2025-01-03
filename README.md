# Uninitialized Property Access in C#

This example demonstrates a common error in C#: attempting to access a property that has not been initialized.  Uninitialized class properties have a default value (e.g., 0 for integers, null for reference types), but directly using them without checking may lead to unexpected behavior or exceptions.

## The Bug

The `bug.cs` file contains a class with a property `MyProperty` that's not explicitly initialized. The `MyMethod` attempts to use this property in a calculation. If no value is explicitly assigned before this line, a `NullReferenceException` will be thrown (if `MyProperty` is a reference type) or it may use the default value causing an unexpected result (if `MyProperty` is a value type).

## The Solution

The `bugSolution.cs` file shows how to avoid this issue.  Proper initialization (explicitly setting the initial value or ensuring it's set before use) prevents the error. This can also be improved by implementing null checks or using the null-coalescing operator.