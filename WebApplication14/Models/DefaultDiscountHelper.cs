using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication14.Interfaces;

namespace WebApplication14.Models
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
       /* public decimal DiscountSize { get; set; }*/

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (10m / 100m * totalParam));
        }
    }

}