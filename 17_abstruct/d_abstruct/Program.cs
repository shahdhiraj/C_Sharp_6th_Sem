namespace d_abstruct;
public abstract  class NetflixPlan{
    protected double rate;
    
    public abstract void getRate();
    public void calculate(int units){
        Console.WriteLine("The amount for {0} units is =Rs.{1}", units ,units*rate);
        }
}
public class BasicPlan:NetflixPlan{
    public override void getRate(){
        rate=1.5;
    }
}
public class GoldUserPlan:NetflixPlan{
    public override void getRate(){
        rate=2.5;
    }
}


public class DiamondUserPlan:NetflixPlan{
    public override void getRate(){
        rate=5.0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        NetflixPlan user;
        Console.WriteLine("Basic Plan");
        user=new BasicPlan();
        user.getRate();
        user.calculate(5);
       Console.WriteLine("----------------------");
       Console.WriteLine("GolUser Plan");
       user=new GoldUserPlan();
       user.getRate();
       user.calculate(2);
        Console.WriteLine("------------");
       Console.WriteLine("DiamondUser Plan");
       user=new DiamondUserPlan();
       user.getRate();
       user.calculate(8);
        Console.WriteLine("------------");
    }
}
