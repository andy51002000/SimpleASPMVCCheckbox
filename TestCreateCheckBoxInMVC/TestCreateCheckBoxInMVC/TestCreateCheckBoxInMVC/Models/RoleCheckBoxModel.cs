﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestCreateCheckBoxInMVC.Models
{
    public class RoleCheckBoxModel
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public bool Checked
        {
            get;
            set;
        }
    }
}