using System.Collections.Generic;

namespace HouseBuildingApp
{
    class Room
    {
        private int _area { get; set; }
        public RoomType Roomtype {get; set;}
        private List<FurnitureType> _furnitureTypes = new List<FurnitureType>();

        public Room(RoomType roomType, int area)
        {
            Roomtype = roomType;
            _area = area;
        }

        public void AddFurniture(Furniture furniture)
        {
            if (_area > 0 || _area < (_area / 2))
            {
                switch (Roomtype)
                {
                    case RoomType.LivingRoom:
                        _area -= furniture.Size;
                        _furnitureTypes.Add(FurnitureType.LivingRoom);
                        break;
                    case RoomType.Kitchen:
                        _area -= furniture.Size;
                        _furnitureTypes.Add(FurnitureType.Kitchen);
                        break;
                    case RoomType.BedRoom:
                        _area -= furniture.Size;
                        _furnitureTypes.Add(FurnitureType.BedRoom);
                        break;
                    case RoomType.BathRoom:
                        _area -= furniture.Size;
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
