﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.Listed);

        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c=>c.ColorId==id),Messages.GetColor);
        }

        public IResult Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult(Messages.Updated);

        }
    }
}
