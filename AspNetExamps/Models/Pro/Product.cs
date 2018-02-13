using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetExamps.Models.Pro
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsTan { get; set; }
    }
}