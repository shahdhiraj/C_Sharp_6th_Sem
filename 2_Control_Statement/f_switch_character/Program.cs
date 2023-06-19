namespace f_switch_character;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter letters a to e(lowercase) to get full name");
        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine("Apple");
                break;
            case "b":
                Console.WriteLine("Ball");
                break;
            case "c":
                Console.WriteLine("Cat");
                break;
            case "d":
                Console.WriteLine("Dog");
                break;
            case "e":
                Console.WriteLine("Elephant");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
        
            
           
    }
}
