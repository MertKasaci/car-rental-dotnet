using CarRental.Entities.Models;
using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Concretes
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateAddress(Address address) =>
            Create(address);
        

        public void DeleteAddress(Address address) =>
            Delete(address);


        public async Task<IEnumerable<Address>> GetAllAddressesAsync(bool isTraceable) =>
            await FindAll(isTraceable)
            .OrderBy(a => a.Id)
            .ToListAsync();
        

        public async Task<Address> GetAddressByIdAsync(Guid id, bool isTraceable) =>
            await FindByCondition((a=>a.Id == id),isTraceable)
            .FirstOrDefaultAsync();
        

        public void UpdateAddress(Address address) =>
            Update(address);
        
    }
}
