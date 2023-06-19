namespace a_single_inheritence;

class  SuperClass{
    public void hi(){
        System.Console.WriteLine("Hi ,this is super Class");
    }
}
class SubClass:SuperClass{
    public void Hello(){
        System.Console.WriteLine("Hello ,this is sub class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        obj.hi();
        obj.Hello();
    }
}
