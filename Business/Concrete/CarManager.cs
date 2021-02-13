using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;

        public CarManager(ICarDal icarDal)
        {
            _icarDal = icarDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>2)
            {
                _icarDal.Add(car);
            }
            else
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _icarDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
   
        public IDataResult< List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            _icarDal.GetAll();
            return new SuccessDataResult<List<Car>>(Messages.CarsListed);
        }

        public IDataResult< List<Car>> GetByCarId(int id)
        {
            return new SuccessDataResult<List<Car>>( _icarDal.GetAll(c => c.Id == id));
        }

        public  IDataResult< List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>( _icarDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _icarDal.Update(car);
           return new SuccessResult(Messages.CarUpdated);    
        }
    }
}
