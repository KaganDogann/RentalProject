using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult("Payment added");
        }

        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new SuccessResult("Payment deleted");
        }
        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult("payment updated");
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll());
        }

        public IDataResult<Payment> GetByPaymentId(int paymentId)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(p => p.PaymentId == paymentId));
        }
    }
}
