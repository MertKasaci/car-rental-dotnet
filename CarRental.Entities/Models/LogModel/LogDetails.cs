using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Models.LogModel
{
    public class LogDetails
    {
        public Object? ModelName { get; set; }
        public Object? Controller { get; set; }
        public Object? Action { get; set; }
        public Object? Id { get; set; }
        public Object? CreatedAt { get; set; }
    }
}
