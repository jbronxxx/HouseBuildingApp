using System.Collections.Generic;

namespace HouseBuildingApp
{
    class House
    {
        public int Area { get; set; }
        public int RoomsAmount { get; set; }
        public RoomType RoomType { get; set; }

        private List<Room> _rooms = new List<Room>();
        private List<Person> _personsAtHome = new List<Person>();

        public House (int area, int roomsAmmount)
        {
            Area = area;
            RoomsAmount = roomsAmmount;
        }

        public void EnterHome(Person person)
        {
            _personsAtHome.Add(person);
        }

        public void LeaveHome(Person person)
        {
            _personsAtHome.Remove(person);
        }
    }
}
