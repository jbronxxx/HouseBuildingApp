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
            house.CreateRoom(new Room(RoomType.BathRoom));
            Console.WriteLine(house.RoomsAmount);
            Room room = new Room(RoomType.BedRoom);
            house.CreateRoom(room);
            room.AddFurniture(new Furniture(FurnitureType.BathRoom));
            room.AddFurniture(new Furniture(FurnitureType.Kitchen));
            room.AddFurniture(new Furniture(FurnitureType.LivingRoom));
            room.AddFurniture(new Furniture(FurnitureType.BedRoom));
            room.AddFurniture(new Furniture(FurnitureType.BathRoom));
            room.AddFurniture(new Furniture(FurnitureType.BathRoom));
            Console.ReadLine();
        }
    }
}