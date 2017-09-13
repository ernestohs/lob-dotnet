using System.Collections.Generic;

namespace Lob.Addresses
{
    public class AddressListResponse
    {
        public IEnumerable<AddressResponse> Addresseses { get; set; }
        public int Count { get; set; }
    }
}