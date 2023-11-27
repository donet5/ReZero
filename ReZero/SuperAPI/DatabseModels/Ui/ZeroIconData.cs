﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReZero.SuperAPI
{
    public class ZeroIconData : DbBase
    { 
        // Name of the icon
        public string? IconName { get; set; }
         

        // Group to which the icon belongs
        public string? GroupName { get; set; }
    }
}