using BoilerPlate.Models;

namespace BoilerPlate.Services
{
    public class TicketService
    {
        private readonly List<Ticket> _tickets = new();
        private int _nextId = 1;

        public Ticket Submit(string user, string content)
        {
            var t = new Ticket { Id = _nextId++, Username = user, Content = content };
            _tickets.Add(t); return t;
        }

        public IEnumerable<Ticket> GetByUser(string user) => _tickets.Where(t => t.Username == user);
        public IEnumerable<Ticket> GetAll() => _tickets;

        public void UpdateStatus(int id, TicketStatus status)
        {
            var t = _tickets.FirstOrDefault(x => x.Id == id);
            if (t != null) t.Status = status;
        }
    }
}