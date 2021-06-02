using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoElectronic.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string AssetNumber { get; set; }
        public string Name { get; set; }
        public int AvailableUnits { get; set; }
        public int ReOrderLevel { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal UnitPrice { get; set; }

    }
}
