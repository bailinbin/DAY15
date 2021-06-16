using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UI.EF
{
    [Table("Work")]
    public class Work
    {
        [Key]
        public int ID   { get; set; }
        public string Name { get; set; }
        public int Cid { get; set; }
        public virtual RI RI { get; set; }
    }
}