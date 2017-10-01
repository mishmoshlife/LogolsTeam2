using System;
using System.Collections.Generic;
using System.Text;
using CoffeeNow.DAL;
using CoffeeNow.Entities;

namespace CoffeeNow.Domain
{
    public class MeasureService
    {
        private MeasureRepository _repository;

        public MeasureService()
        {
            _repository = new MeasureRepository();
        }

        public int Insert(Measure measure)
        {
            return _repository.Insert(measure);
        }

        public void Delete(Measure measure)
        {
            _repository.Delete(measure);
        }

        public void Update(Measure measure)
        {
            _repository.Update(measure);
        }

        public Measure Get(int measureID)
        {
            return _repository.Get(measureID);
        }

        public IEnumerable<Measure> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
