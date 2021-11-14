using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("CongThuc")]
    [Index(nameof(IdMon), Name = "IX_CongThuc_IdMon")]
    [Index(nameof(IdNguyenLieu), Name = "IX_CongThuc_IdNguyenLieu")]
    public partial class CongThuc
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int IdMon { get; set; }
        public int IdNguyenLieu { get; set; }
        public bool? Status { get; set; }

        [ForeignKey(nameof(IdMon))]
        [InverseProperty(nameof(MonAnChiTiet.CongThucs))]
        public virtual MonAnChiTiet IdMonNavigation { get; set; }
        [ForeignKey(nameof(IdNguyenLieu))]
        [InverseProperty(nameof(NguyenLieu.CongThucs))]
        public virtual NguyenLieu IdNguyenLieuNavigation { get; set; }
    }
}
