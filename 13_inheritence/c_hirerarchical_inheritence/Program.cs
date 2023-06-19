namespace c_hirerarchical_inheritence;
class Father{
    public void Dad(){
        System.Console.WriteLine("Hello Child");
    }
}
class Son:Father{
    public void xora(){
        System.Console.WriteLine("Hello Father ,I am your son");
    }
}            
class Daughter:Father{
    public void xori(){
        System.Console.WriteLine("Hello Father ,I am your daughter");
    }
}            
class Program
{
    static void Main(string[] args)
    {
        Son s = new Son();
        s.Dad();
        s.xora();
        
        Daughter d = new Daughter();
        d.Dad();
        d.xori();
    }
}
