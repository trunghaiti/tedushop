﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("PostTag")]
    public class PostTag
    {
        [Key]
        [Column(Order = 1)]
        public int PostID { set; get; }

        [Key]
        [Column(Order = 2,TypeName ="varchar")]
        [Required]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
        
    }
}
