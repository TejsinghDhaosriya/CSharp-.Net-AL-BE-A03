namespace SingletonDesignPatternConsoleApp
{
    // Singleton Pattern - not thread safe
    public sealed class Counter
    {
        private static int _count;
        private static Counter _instance;

        private Counter() { }

        public static Counter GetInstance => _instance ?? (_instance = new Counter());

        public void Increment() => _count++;

        public void Decrement() => _count--;

        public int Count() => _count;
    }
}