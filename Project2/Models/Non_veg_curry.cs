namespace Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Non-veg curry")]
    public partial class Non_veg_curry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("Non-vegCurryName")]
        [Required]
        [StringLength(50)]
        public string Non_vegCurryName { get; set; }

        [Column("Non-vegCurryDescription")]
        [Required]
        [StringLength(250)]
        public string Non_vegCurryDescription { get; set; }

        [Column("Non-vegCurryPrice", TypeName = "numeric")]
        public decimal Non_vegCurryPrice { get; set; }

        [Column("Non-vegCurryImage")]
        [Required]
        [StringLength(10)]
        public string Non_vegCurryImage { get; set; }
    }
}
