namespace DesignPatterns.Console
{
    using DesignPatterns.Composite;
    public class Composite
    {
        static void main(string[] args)
        {
            Worker tom = new Worker("Worker Tom", 5);
            Supervisor mary = new Supervisor("Supervisor Mary", 6);
            Supervisor jerry = new Supervisor("Supervisor Jerry", 7);
            Supervisor bob = new Supervisor("Supervisor Bob", 9);
            Worker jimmy = new Worker("Worker Jimmy", 8);

            //set up the relationships
            mary.AddSubordinate(tom); //Tom works for Mary
            jerry.AddSubordinate(mary); //Mary works for Jerry
            jerry.AddSubordinate(bob); //Bob works for Jerry
            bob.AddSubordinate(jimmy); //Jimmy works for Bob

            //Jerry shows his happiness and asks everyone else to do the same
            if (jerry is IEmployee)
                (jerry as IEmployee).ShowHappiness();
        }
    }
}
