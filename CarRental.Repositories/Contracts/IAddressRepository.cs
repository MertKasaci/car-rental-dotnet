using CarRental.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        Task<IEnumerable<Address>> GetAllAddressesAsync(bool isTraceable);
        Task<Address> GetAddressByIdAsync(Guid id, bool isTraceable);
        void CreateAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(Address address);
    }
}
