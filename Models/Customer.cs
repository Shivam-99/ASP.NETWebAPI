using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Address { get; set; }
    }
}
