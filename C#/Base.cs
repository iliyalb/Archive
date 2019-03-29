class A
{
    protected string name;

    //Constructor 1
    public A()
    {
        System.Console.WriteLine("Constructor 1");
    }

    //Constructor 2
    public A(string name)
    {
        System.Console.WriteLine("Constructor 2");
        this.name = name;
    }
}

class B : A
{
    public B() : base(){}
}

class C : A
{
    public C() : base("something"){}
}

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Creating class B:");
        B class1 = new B();
        System.Console.WriteLine("Creating class C:");
        C class2 = new C();

        System.Console.ReadKey();
    }
}