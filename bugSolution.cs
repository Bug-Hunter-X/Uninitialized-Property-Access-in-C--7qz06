public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with default value

    public void MyMethod()
    {
        // Initialize before use
        MyProperty = 10; 
        int value = MyProperty * 2; // No more potential error
    }
} 