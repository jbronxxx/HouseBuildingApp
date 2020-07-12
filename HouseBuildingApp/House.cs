using System.Collections.Generic;

namespace HouseBuildingApp
{
    class House
    {
        public int Area { get; private set; }
        public int RoomsAmount { get; private set; }

        private List<Room> _rooms = new List<Room>();

        public House (int area, int roomsAmmount, List<Room> rooms)
        {
            Area = area;
            RoomsAmount = roomsAmmount;
            _rooms = rooms;
        }

        // Создает комнаты по одному типу комнаты на дом
        public void CreateRoom(RoomType roomType)
        {
             
        }

        // Вход в дом 
        public void EnterHome(Person person)
        {
            
        }

        // Выход из дома
        public void LeaveHome(Person person)
        {
            
        }
    }
}
