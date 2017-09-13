using System;

namespace Lob.Addresses
{
    public interface IAddress
    {
        string Id { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        string Company { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressCity { get; set; }
        string AddressState { get; set; }
        string AddressZip { get; set; }
        string AddressCountry { get; set; }
    }
}