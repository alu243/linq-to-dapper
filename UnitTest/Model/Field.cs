﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Model
{
    [Table("Field")]
    public class Field
    {
        [Key]
        public int FieldId { get; set; }
        public int DataTypeId { get; set; }
        public string Name { get; set; }
    }
}
