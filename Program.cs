using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human myname = new Human("Brian");
            System.Console.WriteLine(myname.Name);
            Human AllHuman = new Human("Chee", 110, 5, 5, 5);
            System.Console.WriteLine("{0}, {1}, {2}, {3}", AllHuman.Name, AllHuman.Health, AllHuman.strength, AllHuman.intelligence, AllHuman.dexterity);
            myname.Attack(AllHuman.Name, AllHuman.Health);
        }
    }
}
