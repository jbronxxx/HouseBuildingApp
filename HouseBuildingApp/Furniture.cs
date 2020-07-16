using System;

namespace HouseBuildingApp
{
    class Furniture
    {
        public int Size { get; set; }
        public FurnitureType FurnitureType { get; set; }

        public Furniture()
        {

        }
        public Furniture(FurnitureType furnitureType)
        {
            FurnitureType = furnitureType;

            switch(furnitureType)
            {
                case FurnitureType.BathRoom:
                    Size = 1;
                    break;
                case FurnitureType.BedRoom:
                    Size = 2;
                    break;
                case FurnitureType.Kitchen:
                    Size = 2;
                    break;
                case FurnitureType.LivingRoom:
                    Size = 3;
                    break;
                default:
                    throw new ArgumentException("Must be unknown type of furniture.");
            }
        }
    }
}
    