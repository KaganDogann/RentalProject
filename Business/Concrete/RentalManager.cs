using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICarDal _carDal;
        public RentalManager(IRentalDal rentalDal,ICarDal carDal)
        {
            _rentalDal = rentalDal;
            _carDal = carDal;
        }
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult();
           
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetByRentalId(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalsDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult IsCarAvaible(int carId)
        {
            IResult result = BusinessRules.Run(IsCarAvaibleForRent(carId));
            if (result!=null)
            {
                return new ErrorResult("Araç belirtilen aralıkta uygun değil.");
            }
            return new SuccessResult("Belirtilen tarihte araç durumu müsait");
        }

        private IResult IsCarAvaibleForRent(int carId)
        {
            var result=_rentalDal.GetAll(r => r.CarId == carId).Any();
            if (result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public List<int> CalculateTotalPrice(DateTime rentDate, DateTime returnDate, int carId)
        {
            List<int> totalAmount = new List<int>();
            var dateDifference = (returnDate - rentDate).Days;
            //var datesOfDifference = dateDifference.Days;
            var dailyCarPrice = decimal.ToInt32(_carDal.Get(c => c.CarId == carId).DailyPrice); 
           
            var totalPrice = dateDifference * dailyCarPrice;

            totalAmount.Add(dateDifference);
            totalAmount.Add(totalPrice);

            
            return totalAmount;
        }
    }
}
