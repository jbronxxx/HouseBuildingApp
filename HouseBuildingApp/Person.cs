namespace HouseBuildingApp
{
    abstract class Person
    {
        public string Name { get; set; }
        public bool IsFamily { get; set; }
        
        public Person(string name, bool isFamily)
        {
            Name = name;
            IsFamily = isFamily;
        }

        internal abstract void EnterHouse(House house);
        internal abstract void LeaveHouse(House house);
    }
}
