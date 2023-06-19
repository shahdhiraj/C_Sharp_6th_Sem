namespace a_if_positive;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number :");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            System.Console.WriteLine("The number " + num + " is positive number");
        }
    }
}

