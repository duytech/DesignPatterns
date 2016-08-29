namespace DesignPatterns.Composite
{
    using System;
    using System.Collections.Generic;
    public class Supervisor : IEmployee
    {
        private string name;
        private int happiness;

        private IList<IEmployee> subordinate;

        public Supervisor(string name, int happiness)
        {
            this.name = name;
            this.happiness = happiness;
            this.subordinate = new List<IEmployee>();
        }

        void IEmployee.ShowHappiness()
        {
            Console.WriteLine(name + " showed happiness level of " + happiness);
            //show all the subordinate's happiness level
            foreach (IEmployee i in subordinate)
                i.ShowHappiness();
        }

        public void AddSubordinate(IEmployee employee)
        {
            subordinate.Add(employee);
        }

        public void RemoveSubordinate(IEmployee employee)
        {
            subordinate.Remove(employee);
        }
    }
}
