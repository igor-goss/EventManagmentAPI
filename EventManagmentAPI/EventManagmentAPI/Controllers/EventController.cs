using Microsoft.AspNetCore.Mvc;
using EventManagmentAPI.Models;
using EventManagmentAPI.Services.Implemetations;
using AutoMapper;
using EventManagmentAPI.DTOs;
using Microsoft.AspNetCore.Authorization;



namespace EventManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventService _eventService;
        private readonly IMapper _mapper;

        public EventController(EventService eventService, IMapper mapper)
        {
            _eventService = eventService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllEvents()
        {
            var events = _eventService.GetAllEvents();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public IActionResult GetEventById(int id) 
        {
            var @event = _eventService.GetEventById(id);
            if (@event == null)
            {
                return NotFound();
            }
            return Ok(@event);
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateEvent([FromBody] EventDto eventDto) 
        {
            var @event = _mapper.Map<Event>(eventDto);
            

            _eventService.CreateEvent(@event);

            var createdEventDto = _mapper.Map<Event>(@event);
            return CreatedAtAction(nameof(GetEventById), new { id = createdEventDto.Id }, createdEventDto);

        }

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult UpdateEvent(int id, [FromBody] EventDto eventDto)
        {
            var existingEvent = _eventService.GetEventById(id);
            if (existingEvent == null)
            {
                return NotFound();
            }


            existingEvent.Name = eventDto.Name;
            existingEvent.Description = eventDto.Description;
            existingEvent.Speaker = eventDto.Speaker;
            existingEvent.DateTime = eventDto.DateTime;
            existingEvent.Location = eventDto.Location;
            existingEvent.Promoter = eventDto.Promoter;


            _eventService.UpdateEvent(existingEvent);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteEvent(int id)
        {
            var existingEvent = _eventService.GetEventById(id);
            if (existingEvent == null)
            {
                return NotFound();
            }

            _eventService.DeleteEvent(existingEvent.Id);

            return NoContent();
        }
    
    }
}
