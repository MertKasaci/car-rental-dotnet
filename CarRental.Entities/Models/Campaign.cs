using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Models
{
    public class Campaign : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double DiscountPercentage { get; set; }
        public bool IsActive { get; set; }

        //Many To Many With Default Convention To User
        public ICollection<User> Users { get; set; }

        public Campaign()
        {
            Users = new HashSet<User>(); 
        }
    }
}
