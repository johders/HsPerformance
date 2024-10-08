﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsPerformance.User.Mobile.Models
{
    public class BaseExerciseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? VideoUrl { get; set; }
        public string? Description { get; set; }
    }
}
