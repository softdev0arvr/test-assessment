using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HartInterCivic.Models
{
    [Table("Item", Schema = "HartInterCivic")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        public int? Count { get; set; }
    }
}

