namespace c_abstruct;
public abstract class MyCalc{
    public int add(int a, int b){
        return a+b;
    }
}
public class ClassTwo : MyCalc{
    public int sub(int a, int b){
        return a-b;
    }
} 
public class ClassThree : MyCalc{
    public int mul(int a, int b){
        return a*b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClassTwo c1 = new ClassTwo();
        int result = c1.add(10,20);
        ClassThree obj1 = new ClassThree();
        int result2 = obj1.mul(10,20);
        Console.WriteLine("The sum ="+result);
        Console.WriteLine("The sum ="+result2);
        
    }
}
