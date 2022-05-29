using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }
}
