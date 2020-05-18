using System.Collections.Generic;

namespace HouseBuildingApp
{
    class Room
    {
        public string Name { get; set; }
        public int Area { get; set; }

        public Room(string name, int area)
        {
            Name = name;
            Area = area;
        }

        public Furniture AddFurniture(FurnitureType type, int size, Room room, Furniture furniture)
        {
            room.Area -= furniture.Size;
            return new Furniture(type, size);

        }
    }
}
