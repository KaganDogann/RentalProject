using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalDbContext context = new RentalDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 BrandId = b.BrandId,
                                 ModelName = c.ModelName,
                                 ColorId = co.ColorId,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (RentalDbContext context = new RentalDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             where b.BrandId == brandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 BrandId = b.BrandId,
                                 ModelName = c.ModelName,
                                 ColorId = co.ColorId,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (RentalDbContext context = new RentalDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 BrandId = b.BrandId,
                                 ModelName = c.ModelName,
                                 ColorId = co.ColorId,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }
    }
}
