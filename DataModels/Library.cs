﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DataModels
{
    public class Library
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
