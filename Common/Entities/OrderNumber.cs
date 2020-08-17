using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Common.Entities
{
    public class OrderNumber : IdentityBase
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

    }
}
