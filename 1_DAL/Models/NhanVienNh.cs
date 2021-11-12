using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("NhanVienNH")]
    [Index(nameof(Role), Name = "IX_NhanVienNH_Role")]
    public partial class NhanVienNh
    {
        public NhanVienNh()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("MaNV")]
        public int MaNv { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        public int Role { get; set; }
        public bool? Status { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool Sex { get; set; }
        [Required]
        [StringLength(500)]
        public string Address { get; set; }
        [Required]
        [StringLength(12)]
        public string PhoneNo { get; set; }

        [ForeignKey(nameof(Role))]
        [InverseProperty("NhanVienNhs")]
        public virtual Role RoleNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.IdnhanVien1))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
