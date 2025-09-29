using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private readonly List<Event> _events;

        public EventService()
        {
            _events = new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "Conferencia de Tecnología 2024",
                    Date = new DateTime(2024, 12, 15, 9, 0, 0),
                    Location = "Centro de Convenciones, Ciudad de México",
                    Description = "Una conferencia sobre las últimas tendencias en tecnología, inteligencia artificial y desarrollo de software. Expertos internacionales compartirán sus conocimientos.",
                    Capacity = 300,
                    RegisteredCount = 150
                },
                new Event
                {
                    Id = 2,
                    Name = "Gala de Fin de Año Corporativo",
                    Date = new DateTime(2024, 12, 31, 19, 0, 0),
                    Location = "Hotel Grand Palacio, Guadalajara",
                    Description = "Celebración elegante de fin de año para empresas. Incluye cena, espectáculo y networking.",
                    Capacity = 200,
                    RegisteredCount = 180
                },
                new Event
                {
                    Id = 3,
                    Name = "Workshop de Diseño UX/UI",
                    Date = new DateTime(2024, 11, 20, 10, 0, 0),
                    Location = "Coworking Space, Monterrey",
                    Description = "Taller intensivo de diseño de experiencia de usuario con herramientas modernas y mejores prácticas.",
                    Capacity = 50,
                    RegisteredCount = 25
                },
                new Event
                {
                    Id = 4,
                    Name = "Seminario de Marketing Digital",
                    Date = new DateTime(2024, 12, 8, 14, 0, 0),
                    Location = "Universidad Tecnológica, Puebla",
                    Description = "Estrategias modernas de marketing digital, redes sociales y comercio electrónico.",
                    Capacity = 150,
                    RegisteredCount = 120
                },
                new Event
                {
                    Id = 5,
                    Name = "Evento de Networking Empresarial",
                    Date = new DateTime(2024, 11, 25, 18, 0, 0),
                    Location = "Club Empresarial, Tijuana",
                    Description = "Oportunidad única de networking para profesionales y empresarios del noroeste de México.",
                    Capacity = 100,
                    RegisteredCount = 45
                }
            };
        }

        public Task<List<Event>> GetEventsAsync()
        {
            return Task.FromResult(_events);
        }

        public Task<Event?> GetEventByIdAsync(int id)
        {
            var eventItem = _events.FirstOrDefault(e => e.Id == id);
            return Task.FromResult(eventItem);
        }

        public Task<List<Event>> GetAvailableEventsAsync()
        {
            var availableEvents = _events.Where(e => e.IsAvailable).ToList();
            return Task.FromResult(availableEvents);
        }

        public Task<bool> RegisterForEventAsync(Registration registration)
        {
            var eventItem = _events.FirstOrDefault(e => e.Id == registration.EventId);
            if (eventItem != null && eventItem.IsAvailable)
            {
                eventItem.RegisteredCount++;
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
