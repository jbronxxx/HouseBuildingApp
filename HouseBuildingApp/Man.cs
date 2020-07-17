namespace HouseBuildingApp
{
    class Man : Person
    {
        public Man(string name, bool isFamily) : base(name, isFamily) { }

        public override void EnterHouse(House house)
        {
            if (IsFamily)
                house.EnterHome(this);
        }
    }
}
