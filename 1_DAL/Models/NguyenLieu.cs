using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("NguyenLieu")]
    public partial class NguyenLieu
    {
        public NguyenLieu()
        {
            CongThucs = new HashSet<CongThuc>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool? Status { get; set; }

        [InverseProperty(nameof(CongThuc.IdNguyenLieuNavigation))]
        public virtual ICollection<CongThuc> CongThucs { get; set; }
    }
}
