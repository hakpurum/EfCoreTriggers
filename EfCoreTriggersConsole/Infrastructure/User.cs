using System.ComponentModel.DataAnnotations;

namespace EfCoreTriggersConsole.Infrastructure
{
    public class User: Trackable
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
