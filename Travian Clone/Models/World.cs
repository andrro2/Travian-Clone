using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travian_Clone.Models
{
    public class World
    {
        [Key]
        public long Id { set; get; }

        public virtual ICollection<User> Users { set; get; }
        public virtual ICollection<Settlement> Settlements { set; get; }
        public virtual ICollection<WorldLayout> worldTiles { set; get; }
    }
}
