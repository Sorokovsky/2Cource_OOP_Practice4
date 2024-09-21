namespace Individual
{
    public struct MARSH
    {
        public string Start { get; init; }
        public string End { get; init; }
        public int Number {  get; init; }

        public MARSH(string start, string end, int number)
        {
            Start = start;
            End = end;
            Number = number;
        }

        public void Show()
        {
            Console.WriteLine("Початковий пункт маршруту: {0}.", Start);
            Console.WriteLine("Кінцевий пункт маршруту: {0}.", End);
            Console.WriteLine("Номер маршруту: {0}.", Number);
        }
    }
}
