using System.ComponentModel.DataAnnotations;

namespace hackathon.Models
{
    public class SzkolaSrednia : IModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MailPost { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Webpage { get; set; }
        public string maps { get; set; }
        public string img { get; set; }
        public string desc { get; set; }
        public int prywatna { get; set; }
        public string kierunki { get; set; }
        public string typ { get => "srednia"; }
    }
}