public class EventHandler
{
    private List<Event> _events = new List<Event>();

    public EventHandler()
    {

    }

    public void AddEvent(Event newEvent)
    {
        _events.Add(newEvent);
    }

    public void DisplayEvents()
    {
        foreach (Event newEvent in _events)
        {
            newEvent.DisplayStandardMessage();
            newEvent.DisplayFullDetails();
            newEvent.DisplayShortDescription();
        }
    }
}