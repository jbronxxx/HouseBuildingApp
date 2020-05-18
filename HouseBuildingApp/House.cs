using System.Collections.Generic;

namespace HouseBuildingApp
{
    abstract class House
    {
        public int Area { get; set; }
        public int RoomsAmount { get; set; }
        public RoomType RoomType { get; set; }

        private List<RoomType> _rooms { get; set; } = new List<RoomType>();
        private List<Person> _personsAtHome = new List<Person>();

        public House (int area, int roomsAmmount, RoomType room)
        {
            Area = area;
            RoomsAmount = roomsAmmount;
            RoomType = room;
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
