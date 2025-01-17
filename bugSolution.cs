public class MyClass {
    public int MyProperty { get; set; } = 0; // Solution: Initialize the property

    public void MyMethod() {
        Console.WriteLine(MyProperty); // Now it's safe to access
    }
}