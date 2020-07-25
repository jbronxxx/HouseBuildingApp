using System;

namespace HouseBuildingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(150, 4, new Room());
            Man man = new Man("Edward", true);
            man.EnterHouse(house);
            Room.AreaChange areaChange = house.ChangeHouseArea;
            Console.ReadLine();
        }
    }
}