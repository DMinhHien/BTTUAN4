﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BTTUAN4.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CatalogId {  get; set; }
        public string ProductCode {  get; set; }
        public string ProductName {  get; set; }
        public string Picture {  get; set; }
        public double UnitPrice { get; set; }
    }
}
