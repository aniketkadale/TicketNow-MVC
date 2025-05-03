using System.ComponentModel.DataAnnotations;

namespace TicketNow.Models
{
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }

        public String ProfilePictureURL { get; set; }

        public String FullName { get; set; }

        public String Bio { get; set; }

        // Relationships

        public List<Movie> Movies { get; set; }
    }
}
