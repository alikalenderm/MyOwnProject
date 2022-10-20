using MyOwnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyOwnProject.Entities.Concrete
{
    public class Portfolio : IEntity
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioLink { get; set; }
    }
}
