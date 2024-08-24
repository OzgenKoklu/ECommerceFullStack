using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer: IEntity
    {
        public string CustomerId { get; set; }
        public string ContaactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
