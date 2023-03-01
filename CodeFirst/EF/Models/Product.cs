using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.EF.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int Qty { get; set; }
        [ForeignKey("Category")]
        public int Cid { get; set; }

        public virtual Category Category { get; set; }
    }
}