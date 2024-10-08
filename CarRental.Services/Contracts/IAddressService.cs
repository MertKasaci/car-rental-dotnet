using CarRental.Entities.DataTransferObjects.AddressDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Contracts
{
    public interface IAddressService
    {
        Task<IEnumerable<GetAddressResponseDto>> GetAllAddressesAsync(bool isTraceable);
        Task<GetAddressResponseDto> GetAddressByIdAsync(Guid id, bool isTraceable);
        Task<GetAddressResponseDto> CreateAddressAsync(CreateAddressRequestDto createAddressRequestDto);
        Task UpdateAddressAsync(Guid id, UpdateAddressRequestDto updateAddressRequestDto, bool isTraceable);
        Task DeleteAddressAsync(Guid id, bool isTraceable);
    }
}
