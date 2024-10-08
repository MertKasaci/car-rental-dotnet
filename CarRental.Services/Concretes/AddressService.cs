using AutoMapper;
using CarRental.Entities.DataTransferObjects.AddressDTOs;
using CarRental.Entities.Models;
using CarRental.Repositories.Contracts;
using CarRental.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Concretes
{
    public class AddressService : IAddressService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public AddressService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<GetAddressResponseDto> CreateAddressAsync(CreateAddressRequestDto createAddressRequestDto)
        {
            if (createAddressRequestDto is null)
                throw new ArgumentNullException(nameof(createAddressRequestDto));

            var address = _mapper.Map<Address>(createAddressRequestDto);

            _manager.Address.CreateAddress(address);

            await _manager.SaveAsync();

            var addressResponse = _mapper.Map<GetAddressResponseDto>(address);

            return addressResponse;
        }

        public async Task DeleteAddressAsync(Guid id, bool isTraceable)
        {
            var entity = await _manager.Address.GetAddressByIdAsync(id, isTraceable);

            if (entity is null)
                throw new Exception($"Address with id:{id} could not found");

            _manager.Address.DeleteAddress(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<GetAddressResponseDto>> GetAllAddressesAsync(bool isTraceable)
        {
            var addresss = await _manager.Address.GetAllAddressesAsync(isTraceable);

            var addresssResponse = _mapper.Map<IEnumerable<GetAddressResponseDto>>(addresss);

            return addresssResponse;
        }

        public async Task<GetAddressResponseDto> GetAddressByIdAsync(Guid id, bool trackChanges)
        {
            var addresses= await _manager.Address.GetAddressByIdAsync(id, trackChanges);

            if (addresses is null)
                throw new Exception($"Address with id:{id} could not found");

            var addressesResponse = _mapper.Map<GetAddressResponseDto>(addresses);

            return addressesResponse;
        }

        public async Task UpdateAddressAsync(Guid id, UpdateAddressRequestDto updateAddressRequestDto, bool trackChanges)
        {
            var entity = await _manager.Address.GetAddressByIdAsync(id, trackChanges);
            if (entity is null)
                throw new Exception($"Address with id:{id} could not found.");


            entity = _mapper.Map<Address>(updateAddressRequestDto);
            ;

            _manager.Address.UpdateAddress(entity);
            await _manager.SaveAsync();


        }

    }
}
