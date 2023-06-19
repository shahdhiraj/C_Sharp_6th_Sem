namespace b_cons_verloading_by_changing_order_of_parameter;
public class Student{
     public int roll;
     public double height;
     public String name;
     public Student (double h,string n,int r){
        height =h;
        name = n;
        roll =r;
     }
public Student(string n,int r,double h){
    name =n;
    roll=r;
    height=h;
}
public void dispaly(){
    Console.WriteLine("Roll number ="+roll);
    Console.WriteLine("name ="+name);
    Console.WriteLine("height ="+height+"feet");
}
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(5.8,"Ram",23);
        Student s2 = new Student("Ram",23,6.2);
        Console.WriteLine("First Constructor");
        s1.dispaly();
        Console.WriteLine("Second Constructor");
        s2.dispaly();
    }
}
