﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bulky_web_Razor.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1, 100)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
