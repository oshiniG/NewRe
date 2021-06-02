using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoElectronic.Application.ViewModels
{
    public class ItemViewModel
    {
        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets AssetNumber
        /// </summary>
        [Required]
        public string AssetNumber { get; set; }
        /// <summary>
        /// Gets or sets Name
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets AvailableUnits
        /// </summary>
        [Required]
        public int AvailableUnits { get; set; }
        /// <summary>
        /// Gets or sets ReOrderLevel
        /// </summary>
        [Required]
        public int ReOrderLevel { get; set; }
        /// <summary>
        /// Gets or sets UnitPrice
        /// </summary>
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal UnitPrice { get; set; }

    }
}
