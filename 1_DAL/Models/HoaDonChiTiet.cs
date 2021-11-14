using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        public HoaDonChiTiet()
        {
            MonAnChiTiets = new HashSet<MonAnChiTiet>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("IDBill")]
        public int Idbill { get; set; }
        [Column("IDFood")]
        public int Idfood { get; set; }
        public int Count { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public bool? Status { get; set; }

        [ForeignKey(nameof(Idbill))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiets))]
        public virtual HoaDon IdbillNavigation { get; set; }
        [InverseProperty(nameof(MonAnChiTiet.Idunit1))]
        public virtual ICollection<MonAnChiTiet> MonAnChiTiets { get; set; }
    }
}
