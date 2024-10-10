using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BTTUAN4.Models
{
    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        public int Id { get; set; }
        public string CatalogCode {  get; set; }
        public string CatalogName { get; set; }
    }
}
