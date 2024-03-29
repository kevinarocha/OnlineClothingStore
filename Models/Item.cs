﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineClothingStore.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Web.Mvc;


namespace OnlineClothingStore.Models
{
    [Table("Item")]
    public class Item
    {
        [ScaffoldColumn(false)]
        public int ItemId { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [DisplayName("Producer")]
        public int ProducerId { get; set; }
        [Required(ErrorMessage = "An Item title is required")]
        [StringLength(160)]
        public string Title { get; set; }
        [Required(ErrorMessage = "An Item description is required")]
        [StringLength(350)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(0.1, 1000000, ErrorMessage = "price Must be between 0.1 and 100")]
        public decimal Price { get; set; }
        [DisplayName("Item Art Url")]
        [StringLength(1024)]
        public string ItemArtUrl { get; set; }
        public virtual Category Category { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
