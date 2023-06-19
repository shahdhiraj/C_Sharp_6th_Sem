namespace i_non_comptible_using_parse_method;
class Program
{
    static void Main(string[] args)
    {
        string a ="123";
        int b = int.Parse(a);
        Console.WriteLine("a");//Prints string value
        Console.WriteLine("b");//Prints integer value
    }
}
/*
Byte.Parse();
int.Parse();
short.Parse();
bool.Parse(); */
