namespace a_abstruct;
public abstract class Nepal
{
    public abstract void hello();
}
public class Kathmandu : Nepal
{
    public override void hello()
    {
        System.Console.WriteLine("Hello Kathmandu");

    }
}
public class Bhaktapur : Nepal
{
    public override void hello()
    {
        System.Console.WriteLine("Hello Bhaktapur");

    }
} 
   
class Program
{
    static void Main(string[] args)
    {
       Nepal n;
       n=new Kathmandu();
       n.hello();
       n=new Bhaktapur();
       n.hello();
    }
}
