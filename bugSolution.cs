public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize MyProperty before accessing it.
        MyProperty = 0; // Or any other appropriate default value
        Console.WriteLine(MyProperty.ToString());
    }

    public void MyMethod2() {
        Console.WriteLine(MyProperty ?? 0); //Use Null-coalescing operator for shorthand
    }
} 