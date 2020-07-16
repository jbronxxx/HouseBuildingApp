using System;

namespace HouseBuildingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(150, 4);
            house.CreateRoom(new Room(RoomType.BathRoom));
            Console.ReadLine();
        }
    }
}




// To do:
// Реализовать метод распределения типов комнат при создании дома