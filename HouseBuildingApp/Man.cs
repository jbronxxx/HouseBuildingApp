namespace HouseBuildingApp
{
    class Man : Person
    {
        public override void EnterHouse(House house)
        {
            if (IsFamily)
                house.EnterHome(this);
                _currentHouse = house;
        }
    }
}
