using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class UserFavoriteService
    {
        private UserFavoriteRepository _repository;

        public UserFavoriteService()
        {
            _repository = new UserFavoriteRepository();
        }

        public int Insert(UserFavorite userFavorite)
        {
            return _repository.Insert(userFavorite);
        }

        public void Delete(UserFavorite userFavorite)
        {
            _repository.Delete(userFavorite);
        }

        public void Update(UserFavorite userFavorite)
        {
            _repository.Update(userFavorite);
        }

        public UserFavorite Get(int userID, int userFavoriteID)
        {
            return _repository.Get(userID, userFavoriteID);
        }

        public IEnumerable<UserFavorite> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
