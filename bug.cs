public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it's initialized
        Console.WriteLine(MyProperty); // Bug: Potential Uninitialized Property
    }
}