using System.Collections.Generic;

namespace Lob.Addresses
{
    public class Address
    {
        AddressResponse Create(AddressRequest address)
        {
            return default(AddressResponse);
        }
        
        AddressResponse Get(string addressId)
        {
            return default(AddressResponse);
        }
        
        IEnumerable<AddressResponse> GetAll(int offset, int limit)
        {
            return default(IEnumerable<AddressResponse>);
        }
        
        AddressResponse Delete(string addressId)
        {
            return default(AddressResponse);
        }
    }
}