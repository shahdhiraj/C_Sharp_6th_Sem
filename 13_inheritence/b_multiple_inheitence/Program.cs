namespace b_multiple_inheitence;
class GrandFather{
    public void grandDad(){
        Console.WriteLine("This is grand Dad");
    }
}
class Father : GrandFather{
    public void Dad(){
        Console.WriteLine("This is Father");
    }
}
class Child :Father{
    public void child(){
        Console.WriteLine("This is Child");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c =new Child();
        c.grandDad();
        c.Dad();
        c.child();
    }
}
