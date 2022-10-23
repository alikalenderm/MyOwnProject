using MyOwnProject.Core.DataAccess.EntityFramework;
using MyOwnProject.DataAccess.Abstract;
using MyOwnProject.DataAccess.Concrete.Context;
using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.DataAccess.Concrete
{
    public class EfExperienceTwoDal : EfEntityRepositoryBase<ExperienceTwo, MyOwnProjectContext>, IExperienceTwoDal
    {
    }
}
