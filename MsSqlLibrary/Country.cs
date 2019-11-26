using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MsSqlLibrary
{
    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
        }

        [Key]
        [StringLength(3)]
        public string CountryCode { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(2)]
        public string Iso2 { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
