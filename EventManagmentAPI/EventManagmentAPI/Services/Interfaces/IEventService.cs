using EventManagmentAPI.Models;

namespace EventManagmentAPI.Services.Interfaces
{
    public interface IEventService
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEventById(int id);
        void CreateEvent(Event @event);
        void UpdateEvent(Event @event);
        void DeleteEvent(int id);
    }
}
