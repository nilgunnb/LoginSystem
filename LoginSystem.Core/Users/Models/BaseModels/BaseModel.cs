﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Core.Users.Models.BaseModels
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
