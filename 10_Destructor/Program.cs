namespace _10_Destructor;

public class Student
{
    public Student()
    {
        System.Console.WriteLine("Constructor called");
    }
    ~Student()
    {
        System.Console.WriteLine("Destructor Called");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
    }
}
