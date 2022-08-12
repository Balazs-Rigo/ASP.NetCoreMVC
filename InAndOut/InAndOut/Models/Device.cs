using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Device
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string SerialNumber { get; set; }
    }
}
