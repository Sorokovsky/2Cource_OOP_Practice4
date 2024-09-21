//Variant 11

namespace Individual;
public static class Program
{
    public static void Main()
    {
        List<MARSH> list = new();
        while(true)
        {
            int operation = ChooseOperation();
            switch(operation)
            {
                case 0:
                    {
                        return;
                    }
                case 1:
                    {
                        list = EnterList();
                        break;
                    }
                case 2:
                    {
                        ShowList(list);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Введіть пункт призначення для пошуку: "); string port = Console.ReadLine();
                        ShowByPort(list, port);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Невідома операція. Спробуйте ще раз.");
                        break;
                    }
            }
        }
    }

    public static MARSH EnterMarsh()
    {
        Console.Write("Введіть перший пункт маршруту: "); string start = Console.ReadLine();
        Console.Write("Введіть кінцевий пункт маршруту: "); string end = Console.ReadLine();
        Console.Write("Введіть номер маршруту: "); int number = Convert.ToInt32(Console.ReadLine());
        return new MARSH(start, end, number);
    }

    public static void ShowList(List<MARSH> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("#{0}.", i + 1);
            list.ElementAt(i).Show();
        }
    }

    public static void ShowByPort(List<MARSH> list, string port)
    {
        int count = 0;
        foreach (MARSH item in list)
        {
            if(item.Start.Equals(port) || item.End.Equals(port))
            {
                count++;
                Console.WriteLine("#{0}.", count);
                item.Show();
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Таких маршрутів не знайдено.");
        }
    }

    public static List<MARSH> EnterList()
    {
        List<MARSH> list = new();
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("#{0}", i + 1);
            list.Add(EnterMarsh());
        }
        list.Sort((first, second) => first.Number.CompareTo(second.Number));
        return list;
    }

    public static int ChooseOperation()
    {
        Console.WriteLine("Виберіть операцію: ");
        Console.WriteLine("0-Вихід.");
        Console.WriteLine("1-Ввести список.");
        Console.WriteLine("2-Дивитися весь список.");
        Console.WriteLine("3-Дивитися за пунктом маршруту.");
        Console.Write(">> "); 
        return Convert.ToInt32(Console.ReadLine());
    }
}