﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NotasWorkshop.Core.BaseModel.Base
{
    public class Base : IBase
    {
        public virtual int Id { get; set; }
        public virtual bool Deleted { get; set; }
    }
}
