using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public int ProfilePictureUrl { get; set; }
        public int FullName { get; set; }
        public int Biography { get; set; }
    }
}
