namespace TicketTracker2.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Issue { get; set; }
        public string Details { get; set; }
        public DateTime GetDate { get; set; }


        public Ticket(string name, string issue, string details, DateTime getdate)
        {
            Name = name;
            Issue = issue;
            Details = details;
            GetDate = getdate;

        }
    }
}
