internal class Program
{
    private static void Main(string[] args)
    {
        Rectange rectange= new Rectange(4,5);
        //Console.WriteLine($"Chieu rong va cao {rectange.with} {rectange.height}");
        rectange.Show();
        Rectange.Showrec();  
    }
 
}

public class Rectange
{
    public static int rec=10;
    public float with;
    public float height;
    public Rectange(float with, float height)
    {
        this.with = with;
        this.height = height;
    }
    public void Show ()
    {
        Console.WriteLine($"Chieu rong va cao la {with} {height}" );
    }
    public static void Showrec()
    {
        Console.WriteLine($"{rec}");
    }
}
