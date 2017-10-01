using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class UserService
    {
        private UserRepository _repository;

        public UserService()
        {
            _repository = new UserRepository();
        }

        public int Insert(User user)
        {
            return _repository.Insert(user);
        }

        public void Delete(User user)
        {
            _repository.Delete(user);
        }

        public void Update(User user)
        {
            _repository.Update(user);
        }

        public User Get(int userID)
        {
            return _repository.Get(userID);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
