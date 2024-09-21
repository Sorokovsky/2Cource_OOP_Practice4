namespace Task_2;

public static class Program
{
    public static void Main()
    {
        MyClass myClass = new MyClass();
        MyStruct myStruct = new MyStruct();
        myClass.Change = "Не змінено";
        myStruct.Change = "Не змінено";
        Console.WriteLine("Поле класу до змін: {0}", myClass.Change);
        ClassTaker(myClass);
        Console.WriteLine("Поле класу після змін: {0}", myClass.Change);
        Console.WriteLine("Поле структури до змін: {0}", myStruct.Change);
        StructTaker(myStruct);
        Console.WriteLine("Поле структури після змін: {0}", myStruct.Change);
    }

    public static void ClassTaker(MyClass myClass)
    {
        myClass.Change = "Змінено";
    }

    public static void StructTaker(MyStruct myStruct)
    {
        myStruct.Change = "Змінено";
    }
}