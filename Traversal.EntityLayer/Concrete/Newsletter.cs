﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.EntityLayer.Concrete
{
    public class Newsletter
    {
        [Key]
        public int NewsletterID { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
