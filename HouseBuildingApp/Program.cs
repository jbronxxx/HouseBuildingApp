using System;

namespace HouseBuildingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(150, 5, new Room());
            Man man = new Man("Edward", true);
            man.EnterHouse(house);
            house.CreateRoom(new Room(RoomType.BathRoom));
            Console.WriteLine(house.RoomsAmount);
            Room room = new Room();
            room.AddFurniture(new Furniture(FurnitureType.BathRoom));
            Console.ReadLine();
        }
    }
}