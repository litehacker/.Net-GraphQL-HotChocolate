using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Platform
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public string Name {get; set;}
        
        public int LicenseKey { get; set; }
    }
}