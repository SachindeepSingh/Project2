namespace Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vegetration curry")]
    public partial class Vegetration_curry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string VegetrationCurryName { get; set; }

        [Required]
        [StringLength(250)]
        public string VegetrationCurryDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VegetrationCurryPrice { get; set; }

        [Required]
        [StringLength(10)]
        public string VegetrationCurryImage { get; set; }
    }
}
