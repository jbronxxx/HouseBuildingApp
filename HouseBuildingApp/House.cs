using System;
using System.Collections.Generic;

namespace HouseBuildingApp
{
    class House
    {
        public int Area { get; private set; }
        public int RoomsAmount { get; private set; }

        private List<Room> _roomsList = new List<Room>();

        public House (int area, int roomsAmount)
        {
            Area = area;
            RoomsAmount = roomsAmount;
           // Реализовать создание комнат автоматом по типам при создании дома 
        }

        // Создает комнаты по одному типу комнаты на дом
        public void CreateRoom(Room newRoom)
        {
            if (_roomsList.Count < RoomsAmount)
            {
                _roomsList.Add(newRoom);
                this.Area -= newRoom.Area;
            }
            else
            {
                Console.WriteLine($"Rooms ammount is : {0}. You can't create new room.", RoomsAmount);
            }
        }

        // Вход в дом 
        public void EnterHome(Person person)
        {
            if(person.IsFamily)
            {

            }
        }

        // Выход из дома
        public void LeaveHome(Person person)
        {
            
        }
    }
}
