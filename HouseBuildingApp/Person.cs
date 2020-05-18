namespace HouseBuildingApp
{
    abstract class Person
    {
        protected House _currentHouse;

        public string Name { get; set; }
        public bool IsFamily { get; set; }
        public bool CanWalk { get; set; }
        
        public Person() { }

        public Person(string name, bool isFamily)
        {
            Name = name;
            IsFamily = isFamily;
        }

        public abstract void EnterHouse(House house);

        public void MoveToRoom(string roomName)
        {
            if (_currentHouse == null) return;
        }
    }
}
