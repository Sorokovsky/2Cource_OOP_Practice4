using System.Net.NetworkInformation;

namespace Task_1
{
    public struct Notebook
    {
        private int _price;

        public string Name {get; set;}

        public string Creator {get; set;}

        public int Price 
        {
            get 
            {
                return _price;
            }
            set 
            {
                _price = value < 0 ? 0 : value;
            }
        }

        public Notebook()
        {
            Price = 0;
            Name = string.Empty;
            Creator = string.Empty;
        }

        public Notebook(string name, string creator, int price)
        {
            Name = name;
            Creator = creator;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine("Name: {0}.", Name);
            Console.WriteLine("Creator: {0}.", Creator);
            Console.WriteLine("Price: {0}.", Price);
            
            
        }
    }
}