using System;
using System.Collections.Generic;

namespace HouseBuildingApp
{
    delegate void AreaChanged(int furnitureArea);

    class Room
    {
        NotifyMessage notify = NotificationMes;

        public event AreaChanged AreaChangedEvent;
        public int Area { get; private set; }
        public RoomType Roomtype {get; private set;}

        private List<Furniture> _furniture = new List<Furniture>();

        public Room() { }

        #region Room ctor
        public Room(RoomType roomType)
        {
            Roomtype = roomType;

            switch (roomType)
            {
                case RoomType.BathRoom:
                    Area = 15;
                    break;
                case RoomType.BedRoom:
                    Area = 30;
                    break;
                case RoomType.Kitchen:
                    Area = 20;
                    break;
                case RoomType.LivingRoom:
                    Area = 35;
                    break;
                default:
                    throw new ArgumentException("Must be non-residental area.");
            }
        }
        #endregion

        public void AddFurniture(Furniture newFurniture)
        {
            if (this.Area > newFurniture.Size)
            {
                _furniture.Add(newFurniture);
                this.Area -= newFurniture.Size;

                // Вызываем событие обновления площади комнаты. В результате вызова сработают все подписанные методы на это событие. 
                // То есть метод ChandedArea в классе House.
                AreaChangedEvent?.Invoke(newFurniture.Size);
                notify($"New furniture has been added.");
            }
            else { notify($"You don't have enough space to add furniture."); }
        }
        static void NotificationMes(string message) => Console.WriteLine(message);
    }
}
