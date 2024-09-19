namespace Task_1;
public static class Program
{
    public static void Main()
    {
        Console.Write("Enter a name: "); string name = Console.ReadLine();
        Console.Write("Enter a creator: "); string creator = Console.ReadLine();
        Console.Write("Enter a price: "); int price = Convert.ToInt32(Console.ReadLine());
        Notebook notebook = new Notebook(name, creator, price);
        notebook.Show();
    }
}
