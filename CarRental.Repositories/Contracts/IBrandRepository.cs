using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    public interface IBrandRepository : IRepositoryBase<Brand>
    {
        Task<PagedList<Brand>> GetAllBrandsAsync(BrandParameters brandParameters , bool isTraceable);
        Task<Brand> GetBrandByIdAsync(Guid id, bool isTraceable);
        void CreateBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);

    }
}
