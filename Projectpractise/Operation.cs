
internal class Operation
{


    int a, b, c;

    internal void Accept()
    {
        Console.WriteLine("Enter first number");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number");
        b = Convert.ToInt32(Console.ReadLine());
    }
    internal void add()
    {
        c = a + b;
        Console.WriteLine("Addition: " + c);
    }

    internal void sub()
    {
        c = a - b;
        Console.WriteLine(c);

    }
    internal void mul()
    {
        c = a * b;
        Console.WriteLine(c);
    }
    internal void div()
    {
        c = a / b;
        Console.WriteLine(c);

    }
}