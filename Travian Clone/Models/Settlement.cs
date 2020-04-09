using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travian_Clone.Models
{
    public class Settlement
    {
        [Key]
        public long Id { set; get; }
        public virtual Tile position { set; get; }
    }
}
