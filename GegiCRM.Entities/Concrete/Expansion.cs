﻿using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public  class Expansion : BaseEntity
    {
        
        public string ShortCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

    }
}
