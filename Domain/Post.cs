using System.ComponentModel.DataAnnotations;

namespace API_Tutorial.Domain
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
