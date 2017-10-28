using System.ComponentModel.DataAnnotations;

namespace hackathon.Models
{
    public class SzkolaSrednia
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MailPost { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Webpage { get; set; } 
    }
}