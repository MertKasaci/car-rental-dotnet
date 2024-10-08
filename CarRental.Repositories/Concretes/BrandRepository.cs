using CarRental.Entities.Models;
using CarRental.Entities.RequestFeatures;
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
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(CarRentalContext context) : base(context)
        {
        }

        public void CreateBrand(Brand brand) =>
            Create(brand);
        

        public void DeleteBrand(Brand brand) =>
            Delete(brand);


        public async Task<PagedList<Brand>> GetAllBrandsAsync(BrandParameters brandParameters, bool isTraceable)
        {
            var brands = await FindAll(isTraceable)
            .OrderBy(b => b.Id)
            .ToListAsync();

            return PagedList<Brand>
                .ToPagedList(brands, 
                brandParameters.PageNumber, 
                brandParameters.PageSize);
        }

 
        public async Task<Brand> GetBrandByIdAsync(Guid id, bool isTraceable) =>
            await FindByCondition((b => b.Id == id), isTraceable)
            .FirstOrDefaultAsync();
        

        public void UpdateBrand(Brand brand) =>
            Update(brand);
        

    }
}
