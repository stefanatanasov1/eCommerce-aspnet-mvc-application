using Microsoft.AspNetCore.Authentication;

namespace eTickets.Models
{
    public class Producer
    {

        public int Id { get; set; }
        public int ProfilePictureUrl { get; set; }
        public int FullName { get; set; }
        public int Biography { get; set; }
    }
}
