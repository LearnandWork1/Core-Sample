using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreSample.Model.ViewModel
{
    [Table("Dept")]
    public class DeptMaster
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int deptID { get; set; }
        public string? DeptName { get; set; }

        public string? Location { get; set; }

    }
}
