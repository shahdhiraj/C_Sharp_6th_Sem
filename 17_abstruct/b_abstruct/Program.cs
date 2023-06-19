﻿namespace b_abstruct;
public abstract class MyClass
{
    public abstract void calculate(double x);

}
public class SubOne : MyClass
{
    public override void calculate(double x)
    {
        Console.WriteLine("Square root of {0} is {1}.", x, Math.Sqrt(x));
    }
}
public class SubTwo : MyClass
{
    public override void calculate(double x)
    {
        Console.WriteLine("Square root of {0} is ={1}", x, (x * x));
    }
}
public class SubThree : MyClass
{
    public override void calculate(double x)
    {
        Console.WriteLine("Square root of {0} is ={1}", x, (x * x * x));
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubOne obj1 = new SubOne();
        SubTwo obj2 = new SubTwo();
        SubThree obj3 = new SubThree();
        obj1.calculate(25);
        obj2.calculate(5);
        obj3.calculate(78);

    }
}
