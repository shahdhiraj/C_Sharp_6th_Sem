namespace e_single_same_method;
#nullable disable
class SuperClass{
    public void hi(){
        System.Console.WriteLine("Hi,this is super class");
    }
}
class SubClass:SuperClass{
    public new void hi(){
        System.Console.WriteLine("Hello,this is Sub class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClass subo =new SubClass();
        SuperClass supo =new SubClass();
        subo.hi();
        supo.hi();
    }
}
