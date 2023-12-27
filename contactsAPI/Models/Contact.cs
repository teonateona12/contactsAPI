namespace contactsAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

    }
}
 