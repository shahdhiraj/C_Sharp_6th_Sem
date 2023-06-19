namespace d_class_object_data_member;
#nullable disable
class Student
{
    int roll;
    String Name;

    static void Main(string[] args)
    {
        Student s1= new Student();
        s1.roll = 23;
        s1.Name = "Radha";
        Console.WriteLine("Roll :"+s1.roll);
        Console.WriteLine("Name :"+s1.Name);
    }
}
