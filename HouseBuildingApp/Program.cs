using System;

namespace HouseBuildingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(150, 4);
            Man man = new Man("Edward", true);
            man.EnterHouse(house);
            Console.ReadLine();
        }
    }
}