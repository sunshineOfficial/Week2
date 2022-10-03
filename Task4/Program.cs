Messenger.PrintMessage("Hell to world!");
Messenger.PrintMessage("300 bucks", "Van");

static class Messenger
{
    public static void PrintMessage(string message)
    {
        Console.WriteLine($"New message: {message}");
    }

    public static void PrintMessage(string message, string sender)
    {
        Console.WriteLine($"New message: {message}\nFrom: {sender}");
    }
}

class Rectangle
{
    public int a;
    public int b;

    public Rectangle() : this(1) { }
    public Rectangle(int a) : this(a, 1) { }
    public Rectangle(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}