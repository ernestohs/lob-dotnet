using System;
using System.Collections.Generic;
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

        Task<AddressListResponse> GetAllAsync(int offset = 0, int limit = 10)
        {
            return Client.Get<AddressListResponse>("addresses", new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>(nameof(offset), offset),
                new KeyValuePair<string, object>(nameof(limit), limit)
            });
        }

        Task<AddressResponse> DeleteAsync(string addressId)
        {
            return Client.Delete<AddressResponse>(string.Format("addresses/{0}", addressId));
        }
    }
}