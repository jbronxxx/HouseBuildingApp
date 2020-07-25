﻿using System;
using System.Collections.Generic;

namespace HouseBuildingApp
{
    class House
    {
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
        }

        // Создает комнаты по одному типу комнаты на дом
        public void CreateRoom(Room newRoom)
        {
            if (_roomsList.Count < RoomsAmount)
            {
                _roomsList.Add(newRoom);
                this.Area -= newRoom.Area;
            }
            else { Console.WriteLine($"Rooms ammount is : {0}. You can't create new room.", RoomsAmount); }
        }

        public int ChangeHouseArea(Room room)
        {
            return Area -= room.Area;
        }
    }
}
