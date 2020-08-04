using System;

namespace HouseBuildingApp
{
    class Man : Person
    {
        NotifyMessage notify = NotificationMes;
        public event EventHandler AtHome;
        
        public Man(string name, bool isFamily) : base(name, isFamily) { }

        internal override void EnterHouse(House enterHome)
        {
            if (IsFamily)
            {
                enterHome._manAtHome.Add(this);
                notify($"{this.Name} is home now.");
            }
            AtHome?.Invoke(this, null);
        }

        internal override void LeaveHouse(House leaveHome)
        {
            leaveHome._manAtHome.Remove(this);
            notify($"{this.Name} has left the house.");
        }

        static void NotificationMes(string message) => Console.WriteLine(message);
    }
}

// TODO:
// Метод EnterHouse переделать так что добавление в массив будет происходить в самом доме при вызове события