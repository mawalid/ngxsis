﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_marital_status")]
    public class Maritial_Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long marital_status_id { get; set; }

        public long created_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime created_on { get; set; }

        public long modified_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime modified_on { get; set; }

        public long deleted_by { get; set; }

        [Column(TypeName = "Date")]
        public DateTime deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string description { get; set; }

    }
}
