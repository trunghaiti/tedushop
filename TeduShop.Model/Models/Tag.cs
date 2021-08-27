﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Tag")]
    public class Tag 
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string Id { set; get; }

        [MaxLength(50)]
        [Required]
        public string Name { set; get; }

        [MaxLength(50)]
        [Required]
        public string Type { set; get; }


    }
}
