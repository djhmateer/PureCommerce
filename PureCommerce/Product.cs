namespace PureCommerce
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product")]
    public partial class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public bool Featured { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountedUnitPrice { get; set; }
    }
}
