namespace c_id_elseif_ladder_division;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your marks in nepali");
        int nepali = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your marks in english");
        int english = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your marks in maths");
        int maths = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your marks in science");
        int science = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your marks in social");
        int social = Convert.ToInt32(Console.ReadLine());
        int total = nepali + english + maths;
        Console.WriteLine("Total marks is " + total);
        int percentage = total / 5;
        Console.WriteLine("Percentage is " + percentage);
        if (percentage >= 80)
        {
            Console.WriteLine("Grade A");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Grade B");
        }
        else if (percentage >= 40)
        {
            Console.WriteLine("Grade C");
        }
        else if (percentage >= 20)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Grade E");

        }
    }
}