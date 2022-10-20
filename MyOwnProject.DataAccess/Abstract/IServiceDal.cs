using MyOwnProject.Core.DataAccess.Abstract;
using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.DataAccess.Abstract
{
    public interface IServiceDal : IEntityRepository<Service>
    {
    }
}
