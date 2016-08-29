namespace DesignPatterns.Composite
{
    using System;
    public class Worker : IEmployee
    {
        private string name;
        private int happiness;

        public Worker(string name, int happiness)
        {
            this.name = name;
            this.happiness = happiness;
        }

        public void ShowHappiness()
        {
            Console.WriteLine(name + " showed happiness level of " + happiness);
        }
    }
}
