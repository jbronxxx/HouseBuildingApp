using System;

namespace HouseBuildingApp
{
    class Man : Person
    { 
        public event EventHandler AtHome;

        public Man(string name, bool isFamily) : base(name, isFamily) { }

        internal override void EnterHouse(House enterHome)
        {
            if (IsFamily)
                enterHome._manAtHome.Add(this);
            AtHome?.Invoke(this, null);
        }

        internal override void LeaveHouse(House leaveHome)
        {
            leaveHome._manAtHome.Remove(this);
        }
    }
}
