namespace HouseBuildingApp
{
    class Furniture
    {
        public int Size { get; set; }
        public FurnitureType FurnitureType { get; set; }

        public Furniture() { }
        public Furniture(FurnitureType type, int size)
        {
            FurnitureType = type;
            Size = size;
        }
    }
}
    