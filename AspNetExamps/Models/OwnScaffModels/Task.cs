using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetExamps.Models.OwnScaffModels
{
    public class Task
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
    }
}