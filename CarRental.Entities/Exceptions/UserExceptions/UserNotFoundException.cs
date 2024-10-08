using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Exceptions.UserExceptions
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(Guid id) 
            : base($"The book with id : {id} could not found.")
        {
        }
    }
}
