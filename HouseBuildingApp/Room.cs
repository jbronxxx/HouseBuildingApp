namespace HouseBuildingApp
{
    class Room
    {
        private int _area { get; set; }
        public RoomType Roomtype {get; set;}

        public Room(RoomType roomType, int area)
        {
            Roomtype = roomType;
            _area = area;
        }

        public Furniture AddFurniture(Room room, Furniture furniture)
        {
            if (room._area > 0 || room._area < (room._area / 2))
            {
                switch (Furniture.FurnitureType)
                {
                    case FurnitureType.LivingRoom:
                        room._area -= furniture.Size;
                        return new Furniture(FurnitureType.LivingRoom, 5);
                    case FurnitureType.Kitchen:
                        room._area -= furniture.Size;
                        return new Furniture(FurnitureType.Kitchen, 3);
                    case FurnitureType.BedRoom:
                        room._area -= furniture.Size;
                        return new Furniture(FurnitureType.BedRoom, 2);
                    case FurnitureType.BathRoom:
                        room._area -= furniture.Size;
                        return new Furniture(FurnitureType.BathRoom, 4);
                }
            }
            return null;
        }
    }
}
