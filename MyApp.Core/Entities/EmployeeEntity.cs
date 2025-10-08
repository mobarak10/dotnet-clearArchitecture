using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Core.Entities
{

    [Table("Employees")]
    public class EmployeeEntity
    {
        [Key]
        [Column(TypeName = "char(36)")]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; } = null!;

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Email { get; set; } = null!;

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Phone { get; set; } = null!;
    }
}
