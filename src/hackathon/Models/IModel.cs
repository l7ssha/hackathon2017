namespace hackathon.Models
{
    public interface IModel 
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string MailPost { get; set; }
        string Telephone { get; set; }
        string Email { get; set; }
        string Webpage { get; set; }
    }
}