namespace HouseBuildingApp
{
    class Man : Person
    {
        public Man(string name, bool isFamily) : base(name, isFamily) { }

        internal override void EnterHouse(House enterHome)
        {
            if (IsFamily)
                enterHome._manAtHome.Add(this);
        }

        internal override void LeaveHouse(House leaveHome)
        {
            leaveHome._manAtHome.Remove(this);
        }
    }
}
