namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=> StudentPrinter(),
                ()=> EmployeePrinter()
                );
            Console.ReadLine();
        }

        private static void EmployeePrinter()
        {
            Singleton fromstudent = Singleton.GetInstance;
            fromstudent.PrintDetail("Second demo");            
        }

        private static void StudentPrinter()
        {
            Singleton fromemployee = Singleton.GetInstance;
            fromemployee.PrintDetail("First demo");
        }
    }
}