namespace TicketTracker2.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public string ClientName { get; set; }
        public string Issue { get; set; }
        public string Details { get; set; }
        public DateTime SubmittedDateTime { get; set; }


        public Ticket(string agentname, string clientname string issue, string details, DateTime submitteddatetime)
        {
            AgentName = agentname;
            ClientName = clientname;
            Issue = issue;
            Details = details;
            SubmittedDateTime = submitteddatetime;

        }
    }
}
