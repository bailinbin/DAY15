using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UI.EF
{
    [Table("RI")]
    public class RI
    {
        [Key]
        public int Cid   { get; set; }
        public string Cname { get; set; }
        public int Gn  { get; set; }

    }
}