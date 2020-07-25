using System;
using System.Collections.Generic;

namespace HouseBuildingApp
{
    class Room
    {
        public int Area { get; private set; }
        public RoomType Roomtype {get; private set;}

        private List<Furniture> _furniture = new List<Furniture>();

        public Room() { }

        public Room(RoomType roomType)
        {
            Roomtype = roomType;

            switch (roomType)
            {
                case RoomType.BathRoom:
                    Area = 15;
                    break;
                case RoomType.BedRoom:
                    Area = 30;
                    break;
                case RoomType.Kitchen:
                    Area = 20;
                    break;
                case RoomType.LivingRoom:
                    Area = 35;
                    break;
                default:
                    throw new ArgumentException("Must be non-residental area.");
            }
        }

        public void AddFurniture(Furniture newFurniture)
        {
            if (this.Area > newFurniture.Size)
            {
                _furniture.Add(newFurniture);
                this.Area -= newFurniture.Size;
                Console.WriteLine($"New furniture has been added.");
            }
            else { Console.WriteLine($"You don't have enough space to add furniture."); }
        }
    }
}
