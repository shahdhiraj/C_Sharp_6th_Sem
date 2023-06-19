namespace _15_Virtual_Method;
public class SuperClac{
    public int a;
    public int b;
    public virtual int Add(int a,int b){
        return (a+b);
    }
}
public class SubClac:SuperClac{
    public override int Add(int a,int b){
        return (a+b)*5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubClac c1=new SubClac();
       Console.WriteLine("The result is "+c1.Add(18,20));
    }
}
