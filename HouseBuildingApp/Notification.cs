namespace HouseBuildingApp
{
    public delegate void NotifyMessage(string message);

    class Notification
    {
        public event NotifyMessage NotifyEvent;

        public void NotifyAction(string message) => NotifyEvent?.Invoke(message);
    }
}
