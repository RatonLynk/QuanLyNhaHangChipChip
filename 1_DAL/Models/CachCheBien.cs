﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL.Models
{
    [Table("CachChebien")]
    public partial class CachChebien
    {
        public CachChebien()
        {
            MonAnChiTiets = new HashSet<MonAnChiTiet>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool? Status { get; set; }

        [InverseProperty(nameof(MonAnChiTiet.IdmethodNavigation))]
        public virtual ICollection<MonAnChiTiet> MonAnChiTiets { get; set; }
    }
}
