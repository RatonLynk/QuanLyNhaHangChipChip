using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCheckIn { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCheckOut { get; set; }
        [Column("IDtable")]
        public int Idtable { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalMoney { get; set; }
        [Column("IDNhanVien")]
        public int IdnhanVien { get; set; }

        [ForeignKey(nameof(IdnhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien IdnhanVienNavigation { get; set; }
        [ForeignKey(nameof(Idtable))]
        [InverseProperty(nameof(BanAn.HoaDons))]
        public virtual BanAn IdtableNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.IdbillNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
