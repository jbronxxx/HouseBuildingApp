using System;
using System.Collections.Generic;

namespace HouseBuildingApp
{
    public delegate void NotifyMessage(string message);

    class House
    {
        NotifyMessage notify = NotificationMes;

        public int Area { get; private set; }
        public int RoomsAmount { get; private set; }

        private List<Room> _roomsList = new List<Room>();
        internal List<Man> _manAtHome = new List<Man>();

        #region House ctor
        public House (int area, int roomsAmount)
        {
            Area = area;
            RoomsAmount = roomsAmount;

            // При создании дома, автоматически создаются нужные комнаты по умолчанию
            if (_roomsList.Count <= RoomsAmount)
            {
                var bathRoom = new Room(RoomType.BathRoom);
                bathRoom.AreaChangedEvent += ChangeHouseArea;
                _roomsList.Add(bathRoom);

                var bedRoom = new Room(RoomType.BedRoom);
                bedRoom.AreaChangedEvent += ChangeHouseArea;
                _roomsList.Add(bedRoom);

                var livingRoom = new Room(RoomType.LivingRoom);
                _roomsList.Add(livingRoom);
                livingRoom.AreaChangedEvent += ChangeHouseArea;

                var kitchen = new Room(RoomType.Kitchen);
                _roomsList.Add(kitchen);
                kitchen.AreaChangedEvent += ChangeHouseArea;
            }

            notify($"House with {_roomsList.Count} rooms has created!");
        }
        #endregion

        // Создает комнаты по одному типу комнаты на дом
        public void CreateRoom(Room newRoom)
        {
            if (_roomsList.Count < RoomsAmount)
            {
                // При каждом создании комнаты,подписываемся на её событие изменения площади комнаты. 
                // Мы с помощью += говорим что нужно событию AreaChanged в Room вызвать метод ChangeHouseArea при срабатывании события.
                newRoom.AreaChangedEvent += ChangeHouseArea;
                _roomsList.Add(newRoom);
                this.Area -= newRoom.Area;
            }
            else { notify($"Rooms ammount is : {RoomsAmount}. You can't create new room."); }
        }

        //Обработчик события изменения Area в комнате.
        private void ChangeHouseArea(int furnitureArea)
        {
            //Минусуем из площади дома размер только что добавленной мебели.
            this.Area -= furnitureArea;
            notify($"House area changed to: {this.Area}");
        }

        static void NotificationMes(string message) => Console.WriteLine(message);
    }
}
