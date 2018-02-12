using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetExamps.Models
{
    public class TaskModel
    {
        public string Name { get; set; }
        public string StartDate { get; set; }
        public bool Complete { get; set; }
    }
}