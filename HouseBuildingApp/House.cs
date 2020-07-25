using System;
using System.Collections.Generic;

namespace HouseBuildingApp
{
    class House
    {
        public delegate void RoomCreateHandler(string message);
        public event RoomCreateHandler Notification = NotificationMes;
        public delegate void AreaChangeHandler(House house, Room room);
        public event AreaChangeHandler AreaChangeEvent = new AreaChangeHandler(ChangeHouseArea);


        public int Area { get; private set; }
        public int RoomsAmount { get; private set; }

        private List<Room> _roomsList = new List<Room>();
        internal List<Man> _manAtHome = new List<Man>();

        public House (int area, int roomsAmount, Room room)
        {
            Area = area;
            RoomsAmount = roomsAmount;

            // При создании дома, автоматически создаются нужные комнаты по умолчанию
            if(_roomsList.Count <= RoomsAmount)
            {
                _roomsList.Add(new Room(RoomType.BathRoom));
                _roomsList.Add(new Room(RoomType.BedRoom));
                _roomsList.Add(new Room(RoomType.LivingRoom));
                _roomsList.Add(new Room(RoomType.Kitchen));
            }

            Notification?.Invoke($"House with {_roomsList.Count} rooms has created!");
        }

        // Создает комнаты по одному типу комнаты на дом
        public void CreateRoom(Room newRoom)
        {
            if (_roomsList.Count < RoomsAmount)
            {
                _roomsList.Add(newRoom);
                this.Area -= newRoom.Area;
            }
            else { Notification?.Invoke($"Rooms ammount is : {RoomsAmount}. You can't create new room."); }
        }

        static void ChangeHouseArea(House house, Room room)
        {
            house.Area -= room.Area;
            Console.WriteLine($"House area changed to: {house.Area}");
        }
        public static void NotificationMes(string message) => Console.WriteLine(message);
    }
}
