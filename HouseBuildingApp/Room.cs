using System.Collections.Generic;

namespace HouseBuildingApp
{
    class Room
    {
        public int Area { get; set; }
        public RoomType Roomtype {get; set;}
        private List<FurnitureType> _furnitureTypes = new List<FurnitureType>();

        public Room(RoomType roomType, int area)
        {
            Roomtype = roomType;
            Area = area;
        }

        public void AddFurniture(Furniture furniture)
        {
            if (Area > 0 || Area < (Area / 2))
            {
                switch (Roomtype)
                {
                    case RoomType.LivingRoom:
                        Area -= furniture.Size;
                        _furnitureTypes.Add(FurnitureType.LivingRoom);
                        break;
                    case RoomType.Kitchen:
                        Area -= furniture.Size;
                        _furnitureTypes.Add(FurnitureType.Kitchen);
                        break;
                    case RoomType.BedRoom:
                        Area -= furniture.Size;
                        _furnitureTypes.Add(FurnitureType.BedRoom);
                        break;
                    case RoomType.BathRoom:
                        Area -= furniture.Size;
                         _furnitureTypes.Add(FurnitureType.BathRoom);
                        break;
                }
            }
            else
            {
                return;
            }
        }
    }
}
