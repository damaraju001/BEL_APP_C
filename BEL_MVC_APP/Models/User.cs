using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEL_MVC_APP.Models
{
    [Table("USERS")]
    public class User
    {
        public int ID { get; set; }

        [MaxLength(10)]
        public int Mobile { get; set; }
    }
}
