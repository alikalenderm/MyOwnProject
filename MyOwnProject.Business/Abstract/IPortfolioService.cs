using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface IPortfolioService
    {
        List<Portfolio> Getlist();
        void Add(Portfolio portfolio);
        void Update(Portfolio portfolio);
        Portfolio GetById(int id);
        void Delete(int id);
    }
}
