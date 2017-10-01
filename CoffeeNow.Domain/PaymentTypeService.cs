using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class PaymentTypeService
    {
        private PaymentTypeRepository _repository;

        public PaymentTypeService()
        {
            _repository = new PaymentTypeRepository();
        }

        public int Insert(PaymentType payment_type)
        {
            return _repository.Insert(payment_type);
        }

        public void Delete(PaymentType payment_type)
        {
            _repository.Delete(payment_type);
        }

        public void Update(PaymentType payment_type)
        {
            _repository.Update(payment_type);
        }

        public PaymentType Get(int paymentTypeID)
        {
            return _repository.Get(paymentTypeID);
        }

        public IEnumerable<PaymentType> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
