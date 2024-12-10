﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Module
    {
        public long Id { get; set; }
        public long IdParent { get; set; }
        public string MenuItemName { get; set; }
        public string? DllName { get; set; }
        public string? FunctionName { get; set; }
        public int SequenceNumber { get; set; }
        public bool AllowRead { get; set; }
        public bool IsNecessary { get; set; }
        public bool IsMethodTakeable { get; set; }
    }
}
