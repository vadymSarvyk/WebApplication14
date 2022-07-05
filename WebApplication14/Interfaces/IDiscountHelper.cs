using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication14.Interfaces
{
 public   interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
}
