using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class OrderItemService
    {
        private OrderItemRepository _repository;

        public OrderItemService()
        {
            _repository = new OrderItemRepository();
        }

        public int Insert(OrderItem order_item)
        {
            return _repository.Insert(order_item);
        }

        public void Delete(OrderItem order_item)
        {
            _repository.Delete(order_item);
        }

        public void Update(OrderItem order_item)
        {
            _repository.Update(order_item);
        }

        public OrderItem Get(int orderItemID)
        {
            return _repository.Get(orderItemID);
        }

        public IEnumerable<OrderItem> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
