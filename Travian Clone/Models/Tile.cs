using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Travian_Clone.Enums;

namespace Travian_Clone.Models
{
    public class Tile
    {
        [Key]
        public long Id { set; get; }
        public virtual TileTypeEnum tileType { set; get; }

        public long SettlementId { set; get; }
        public virtual Settlement tileSettlement { set; get; }
    }
}
