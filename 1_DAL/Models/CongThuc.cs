using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("CongThuc")]
    public partial class CongThuc
    {
        public CongThuc()
        {
        }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public int IdMon { get; set; }
        public int IdNguyenLieu { get; set; }
        public bool? Status { get; set; }
        [ForeignKey(nameof(IdNguyenLieu))]
        [InverseProperty(nameof(NguyenLieu.CongThucs))]
        public virtual NguyenLieu IdNguyenLieuNavigation { get; set; }
        [ForeignKey(nameof(IdMon))]
        [InverseProperty(nameof(MonAnChiTiet.CongThucs))]
        public virtual MonAnChiTiet IdMonNavigation { get; set; }
    }
}
