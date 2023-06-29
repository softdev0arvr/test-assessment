using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HartInterCivic.Models
{
    [Table("TimerConfiguration", Schema = "HartInterCivic")]
    public class TimerConfiguration
    {
        [Key]
        public int Id { get; set; }
        public int Interval { get; set; }
        public bool AutoStart { get; set; }
    }
}

