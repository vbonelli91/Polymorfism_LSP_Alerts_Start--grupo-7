namespace LSPLibrary
{
    public class Event
    {
        public string EventName { get; set; }
        public string EventType { get; set; }

        public void Notify()
        {
            new Alert().Send("text", this.EventName);

            if (this.EventType == "severe")
            {
                new Alert().Send("trello", this.EventName);
            }
        }
    }
}