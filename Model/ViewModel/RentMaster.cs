using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreSample.Model.ViewModel
{
    [Table("Rents")]
    public class RentMaster
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RentID { get; set; }
        public string? Name { get; set; }
        public string? HomeType { get; set; }
        public string? LandMark { get; set; }
        public string? Location { get; set; }
        public string? Details { get; set; }
        public string? Preferance { get; set; }
    }
}
