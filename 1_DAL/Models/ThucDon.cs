using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("ThucDon")]
    public partial class ThucDon
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public bool? Status { get; set; }

        [InverseProperty("MaMonNavigation")]
        public virtual MonAnChiTiet MonAnChiTiet { get; set; }
    }
}
