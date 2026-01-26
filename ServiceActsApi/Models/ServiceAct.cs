using System.ComponentModel.DataAnnotations;

namespace ServiceActsApi.Models
{
    public class ServiceAct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}