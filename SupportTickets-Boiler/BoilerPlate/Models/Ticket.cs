namespace BoilerPlate.Models
{
    public enum TicketStatus { Submitted, InProgress, Resolved }

    public class Ticket
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string Content { get; set; } = "";
        public TicketStatus Status { get; set; } = TicketStatus.Submitted;
    }
}