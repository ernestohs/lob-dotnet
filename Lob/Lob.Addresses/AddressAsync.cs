using System;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using Lob.Core;

namespace Lob.Addresses
{
    public class AddressAsync
    {
        public Client Client { get; set; }

        public AddressAsync(Client client)
        {
            Client = client;
        }

        Task<AddressResponse> Create(AddressRequest address)
        {
            return Client.Post<AddressResponse, AddressRequest>("addresses", address);
        }

        Task<AddressResponse> Get(string addressId)
        {
            return Client.Get<AddressResponse>(string.Format("addresses/{0}", addressId));
        }

        Task<IQueryable<AddressResponse>> GetAllAsync()
        {
            throw new NotImplementedException("We need to define a clean API");
        }

        Task<AddressResponse> DeleteAsync(string addressId)
        {
            return Client.Delete<AddressResponse>(string.Format("addresses/{0}", addressId));
        }
    }
}