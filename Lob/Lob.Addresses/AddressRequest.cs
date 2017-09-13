namespace Lob.Addresses
{
    public class AddressRequest:IAddress
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }
    }
}