using BoilerPlate.Models;

namespace BoilerPlate.Services
{
    public class TicketService
    {
        private readonly List<Ticket> _tickets = new();
        private int _nextId = 1;
        private readonly Random _rng = new();

        public Ticket SaveDraft(string user, string content)
            => Create(user, content, TicketStatus.Draft);

        public Ticket Submit(string user, string content)
            => Create(user, content, TicketStatus.Submitted);

        private Ticket Create(string user, string content, TicketStatus status)
        {
            var t = new Ticket
            {
                Id = _nextId++,
                Username = user,
                Content = content,
                Status = status,
                LinkId = _rng.Next(0, 10_000_000).ToString("D7")
            };
            _tickets.Add(t);
            return t;
        }

        public IEnumerable<Ticket> GetByUser(string user) =>
            _tickets.Where(t => t.Username == user);

        public IEnumerable<Ticket> GetAll() => _tickets;

        public void UpdateStatus(int id, TicketStatus s)
        {
            var t = _tickets.FirstOrDefault(x => x.Id == id);
            if (t != null) t.Status = s;
        }
    }
}