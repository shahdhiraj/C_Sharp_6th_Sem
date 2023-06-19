namespace _14_Encapsulation;
#nullable disable
public class Cuboid{
    private double Lenght;
    private double Breadth;
    private double height;
    public void inputData(){
        Console.WriteLine("Enetr the lenght:");
        Lenght = Convert.ToDoble(console.Readline());
        Console.WriteLine("Enetr the breadth:");
        Breadth = Convert.ToDoble(console.Readline());
        Console.WriteLine("Enetr the height:");
        height = Convert.ToDoble(console.Readline());

    }
    public double vol(){
        return (Lenght*Breadth*height);
    }
    public void displayVol(){
    Console.WriteLine("Volume of the is :" +vol());
}
}

class Program
{
    static void Main(string[] args)
    {
        Cuboid c1=new Cuboid();
        c1.inputData();
        c1.displayVol();
    }
}
