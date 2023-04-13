namespace kek
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var bus = new Bus();
            bus.Load = 0;
            bus.PrintStatus();
        }
        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if (this.Load != null && this.Load > 0)
                    Console.WriteLine("В автобусте: {0}", this.Load);
                else 
                    Console.WriteLine("Автобус пуст");
                
            }
        }

    }
}