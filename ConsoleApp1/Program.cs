using System;

namespace ConsoleApp3
{
    public class Info : EventArgs
    {
        public static char x { get; set; }
    }
    public class EventClass 
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run(char t)
        {
            while (t != 'c' && t != 'C')
            {
                t = Console.ReadKey().KeyChar;
                OnKeyPressed?.Invoke(this, t);
            } 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventClass obj = new EventClass();
            obj.OnKeyPressed += HandlerMethod;
            obj.Run(Info.x);
        }

        static void HandlerMethod(object source, char t)
        {
            Console.WriteLine("\nВводимый символ: " + t );
        }
    }
}
