using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class OrderService
    {
        private OrderRepository _repository;

        public OrderService()
        {
            _repository = new OrderRepository();
        }

        public int Insert(Order order)
        {
            return _repository.Insert(order);
        }

        public void Delete(Order order)
        {
            _repository.Delete(order);
        }

        public void Update(Order order)
        {
            _repository.Update(order);
        }

        public Order Get(int orderID)
        {
            return _repository.Get(orderID);
        }

        public IEnumerable<Order> GetAll()
        {
            return _repository.GetAll();
        }

        
    }
}
