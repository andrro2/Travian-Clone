using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Travian_Clone.Enums;

namespace Travian_Clone.Models
{
    public class User : IdentityUser
    {
        [NotMapped]
        public string Password { set; get; }

        public virtual ICollection<Settlement> Settlements { get; set; }
    }
}
