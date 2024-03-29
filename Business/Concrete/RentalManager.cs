﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
        public RentalManager(IRentalDal rental)
        {
            _rentalDal = rental;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental entity)
        {
            var result = GetCarAvailable(entity.CarId).Data.ReturnDate;
            if (result == null)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }
            _rentalDal.Add(entity);
            return new SuccessResult(Messages.RentalValid);
        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Rental> GetCarAvailable(int carId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetCarAvailable(r => r.CarId == carId), Messages.Added);
        }

        public IDataResult<List<RentalDetailsDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailsDto>>(_rentalDal.GetRentalDetails(),Messages.Listed);
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult();
        }
    }
}
