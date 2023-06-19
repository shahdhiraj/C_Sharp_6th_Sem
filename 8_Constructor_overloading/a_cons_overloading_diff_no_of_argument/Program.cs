namespace a_cons_overloading_diff_no_of_argument;
#nullable disable

public class Add
{
    int a, b;
    int x, y, z;
    public Add(int m, int n)
    {
        a = m;
        b = n;


    }
    public Add(int p, int q, int r)
    {
        p = x;
        q = y;
        r = z;
    }
    public void dispalyOne()
    {
        System.Console.WriteLine("The Sum of int+int ={0}", (a + b));
    }
    public void dispalyTwo()
    {
        System.Console.WriteLine("The Sum of int+int+int ={0}", (x+y+z));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Add a1 = new Add(10, 30);
        Add a2 = new Add(10, 30, 80);
        a1.dispalyOne();
        a2.dispalyTwo();
    }
}
