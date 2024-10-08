using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.RequestFeatures
{
    public class ReviewParameters : RequestParameters
    {
        public ReviewParameters()
        {
            OrderBy = "id";
        }
    }
}
